using UnityEngine;
using System.Collections;

public class OrbitsObjects : MonoBehaviour
{

    public Transform target;
    public float orbitDistance = 10.0f;
    public float orbitDegreesPerSec = 180.0f;
    public Vector3 relativeDistance = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        
        if (target != null)
        {
            //relativeDistance = target.position - transform.position;
            relativeDistance = new Vector3(10, 0, 0);
        }
    }

    void Orbit()
    {
        if (target != null)
        {
            // Keep us at the last known relative position
            transform.position = target.position - relativeDistance;
            transform.RotateAround(target.position,Vector3.up, orbitDegreesPerSec * Time.deltaTime);
            // Reset relative position after rotate
            relativeDistance = target.position - transform.position;
        }
    }

    void LateUpdate()
    {
        Orbit();

    }
}