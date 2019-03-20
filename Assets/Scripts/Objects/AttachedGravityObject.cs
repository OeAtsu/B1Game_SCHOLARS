using UnityEngine;

namespace _Scripts
{
    /// <summary>
    /// Gravity behavioura added to object
    /// </summary>
    public class AttachedGravityObject : MonoBehaviour
    {

        //public SphereCollider myCollider;


        public float PullRadius; // Radius to pull
        public float GravitationalPull; // Pull force
        public float MinRadius; // Minimum distance to pull from
        public float DistanceMultiplier; // Factor by which the distance affects force

        public LayerMask LayersToPull;

        public Vector3 Direction;
        public float maxSpeed = 5f;


        private void Start()
        {
            //Assigns the attached SphereCollider to myCollider
            //myCollider = GetComponent<SphereCollider>();

            PullRadius = gameObject.GetComponent<SphereCollider>().radius;
        }

        // Function that runs on every physics frame

        void FixedUpdate()
        {

            if (PlayerManager.instance.myState == PlayerManager.StatesOfGrav.IsCleaning)
            {
                if (PlayerManager.instance.isGravObject == true)
                {

                    Collider[] colliders = Physics.OverlapSphere(transform.position, PullRadius, LayersToPull);

                    foreach (var collider in colliders)
                    {
                        Rigidbody rb = collider.GetComponent<Rigidbody>();

                        if (rb == null) continue; // Can only pull objects with Rigidbody

                        Vector3 direction = transform.position - collider.transform.position;

                        //if (direction.magnitude < MinRadius) continue;

                        float distance = direction.sqrMagnitude * DistanceMultiplier + 1; // The distance formula

                        // Object mass also affects the gravitational pull
                        //Direction = orbitCenterPlayer.relativeDistance.normalized;
                        Direction = PlayerManager.instance.GetComponent<Rigidbody>().velocity.normalized;
                        //Debug.Log(gameObject.GetComponent<Rigidbody>().velocity);

                        PlayerManager.instance.GetComponent<Rigidbody>().AddForce(Direction, ForceMode.Acceleration);

                        if (PlayerManager.instance.GetComponent<Rigidbody>().velocity.magnitude > maxSpeed) // Limit max speed
                        {
                            PlayerManager.instance.GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(PlayerManager.instance.GetComponent<Rigidbody>().velocity, maxSpeed);
                        }

                        rb.AddForce(direction.normalized * (GravitationalPull / distance) * rb.mass * Time.fixedDeltaTime);
                        //Debug.Log(PlayerManager.instance.GetComponent<Rigidbody>().velocity);


                    }
                }
            }
        }

    }
}