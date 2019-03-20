using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFreeMode : MonoBehaviour
{
    public Vector3 Direction;
    public Vector3 Dir;
    public OrbitCenterPlayer orbitCenterPlayer;



    void Start()
    {
        orbitCenterPlayer = GetComponent<OrbitCenterPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.instance.myState == PlayerManager.StatesOfGrav.Free)
        {
            Velocity();
        }
        

    }
    void Velocity()
    {
        //Direction = orbitCenterPlayer.relativeDistance.normalized;
        Direction = gameObject.GetComponent<Rigidbody>().velocity.normalized;
        //Debug.Log(gameObject.GetComponent<Rigidbody>().velocity);
        GetComponent<Rigidbody>().AddForce(Direction,ForceMode.Acceleration);

        /*
        Vector3 dir = Vector3.zero;
        dir *= Time.deltaTime;
        Debug.Log(dir);
        // Move object
        gameObject.GetComponent<Rigidbody>().transform.Translate(dir * PlayerManager.instance.speed);
        */
    }
}