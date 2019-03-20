using UnityEngine;
using System.Collections;

public class OrbitCenterPlayer : MonoBehaviour
{
    public Transform target;
    public float orbitDistance = 2f;
    public float orbitDegreesPerSec = 90f;
    public Vector3 relativeDistance = Vector3.zero;
    public Vector3 v;



    // Use this for initialization
    void Start()
    {
        if (target != null)
        {
            v = new Vector3(4, 0, 0);
            relativeDistance = target.position - transform.position;
            //relativeDistance = new Vector3(2, 0, 0);
        }
    }

    void Orbit()
    {
        if (target != null)
        {

            Quaternion q = Quaternion.AngleAxis(orbitDegreesPerSec * Time.fixedDeltaTime, Vector3.up);
            v = q * v;
            gameObject.GetComponent<Rigidbody>().MovePosition(target.position + v);
            gameObject.GetComponent<Rigidbody>().MoveRotation(q * transform.rotation);

            // Keep us at the last known relative position
            // transform.position = target.position - relativeDistance;
            //transform.RotateAround(target.position, new Vector3(0,0,1), orbitDegreesPerSec * Time.deltaTime);
            // Reset relative position after rotate
            //relativeDistance = target.position - transform.position;
        }
    }

    void FixedUpdate()
    {
        Debug.Log(PlayerManager.instance.myState.ToString());

        if(PlayerManager.instance.myState == PlayerManager.StatesOfGrav.OnGravCenter)
        {
            Orbit();
        }
    }
}