using UnityEngine;
using System.Collections;

public class CleanningOrbitObject : MonoBehaviour
{

    public Transform target;
    public float orbitDistance = 5.0f;
    public float orbitDegreesPerSec = 180f;
    public Vector3 relativeDistance = Vector3.zero;
    

    // Use this for initialization
    void Start()
    {
        
        if (target != null)
        {
            
            relativeDistance = target.position - transform.position;
           //relativeDistance = new Vector3(0, 0, 0);
        }
    }

    private void Update()
    {
       
    }

    void OrbitToThatObject()
    {
        if (target != null)
        {
            // Keep us at the last known relative position
            transform.position = target.position - relativeDistance;
            transform.RotateAround(target.position,new Vector3(0,0,1), orbitDegreesPerSec * Time.deltaTime);
            // Reset relative position after rotate
            relativeDistance = target.position - transform.position;
        }
    }

    void FixedUpdate()
    {
        Debug.Log(PlayerManager.instance.myState.ToString());

        if (PlayerManager.instance.myState == PlayerManager.StatesOfGrav.IsCleaning)
        {
            OrbitToThatObject();

        }

    }
}