using UnityEngine;

namespace _Scripts
{
    /// <summary>
    /// Gravity behavioura added to object
    /// </summary>
    public class GravityObjectManager : MonoBehaviour
    {

        //public SphereCollider myCollider;


        public float PullRadius; // Radius to pull
        public float GravitationalPull; // Pull force
        public float MinRadius; // Minimum distance to pull from
        public float DistanceMultiplier; // Factor by which the distance affects force

        public LayerMask LayersToPull;

        private void Start()
        {
            PullRadius = 100; // Diametre d'attraction
        }


        void FixedUpdate()
        {
            
            if (PlayerManager.instance.myState == PlayerManager.StatesOfGrav.OnGravCenter)
            {
                
                    Rigidbody rb = PlayerManager.instance.GetComponent<Rigidbody>();

                    Vector3 direction = transform.position - PlayerManager.instance.transform.position;

                    if (direction.magnitude < MinRadius)
                    return;

                    float distance = direction.sqrMagnitude * DistanceMultiplier + 1; // The formule de distance
          
                    // La masse de l'objet affecte la pussiance de la gravitée
                    rb.AddForce(direction.normalized * (GravitationalPull / distance) * rb.mass * Time.fixedDeltaTime);

                    //Debug.Log(PlayerManager.instance.GetComponent<Rigidbody>().velocity);


                
            }
        }

    }
}