using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attract : MonoBehaviour
{
      
    public float g;
    public float distance;
    

    //public static List<Attractor> Attractors;
    public GameObject objToAttract;
    public Rigidbody myRigidBody;
    public bool isEnable = false;
    Vector3 force;

    public CleanningOrbitObject OrbitPlayer;

    private void Start()
    {
        OrbitPlayer = GetComponent<CleanningOrbitObject>();

    }

    void FixedUpdate()
    {
        g = GameManager.instance.G;
        if (isEnable == true)
        {
           // OnDisable();
            Attracted();
        }
    }
/*
    void OnEnable ()
    { 
            GameManager.instance.G = 0;
            OrbitPlayer.enabled = true;

    }

	void OnDisable ()
	{
            GameManager.instance.G = 9;
            OrbitPlayer.enabled = false;
    }

*/
    public void Attracted()
        {
            Rigidbody rigidbodyToAttract = objToAttract.GetComponent<Rigidbody>();

            Vector3 direction = myRigidBody.transform.position - rigidbodyToAttract.position;
            distance = direction.normalized.magnitude;

            if (distance == 0.8f)
                return;

            float forceMagnitude = g * (myRigidBody.mass * rigidbodyToAttract.mass) / Mathf.Pow(distance, 2);
            force = direction.normalized * forceMagnitude;
        if (distance >= 0.1f)
        {
            rigidbodyToAttract.AddForce(force, ForceMode.Force);
        }
        }

    }
