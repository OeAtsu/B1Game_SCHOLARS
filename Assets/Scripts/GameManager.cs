using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null; //Singleton

    public GameObject Drone;
    public OrbitCenterPlayer orbitCenterPlayer;

    public Vector3 vectorgravity;
    public float G = 9f;



    //Awake is always called before any Start functions for Singleton
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

    
    }

        // Use this for initialization
        void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {

    }
}