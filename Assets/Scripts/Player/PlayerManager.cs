using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static PlayerManager instance = null; //Singleton


    public bool isGravCenter;
    public bool isGravObject;
    public bool isFree;
    public bool isCleanning;

    public enum StatesOfGrav { OnGravCenter, Free, IsCleaning }; // Trois etats du drone
    public StatesOfGrav myState;


    public Transform TargetContact;
    private CleanningOrbitObject OrbitPlayer;

    public float timeLeft; // cooldown pour le retour à la gravitée Centrale après un "clean" fini

    //public float speed = 10.0f;

    public float maxSpeed = 10f; // Velocitée max du drone

    Vector3 Direction; // pour le calcul de la direction 



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


    } // Pour le Singleton

    void Start()
    {
        myState = StatesOfGrav.OnGravCenter; // initialise l'Etat

        OrbitPlayer = GetComponent<CleanningOrbitObject>(); // Pour stocker le transform de l'objet à netoyyer
    }

    // Update is called once per frame
    void Update()
    {
        MyState();

        if (!GameManager.instance.isFinish)
        {
            if (!(Input.GetKeyDown(KeyCode.Space)) && (GameManager.instance.isFinish == true)) // Velocity control
            {
                Direction = gameObject.GetComponent<Rigidbody>().velocity.normalized;

                gameObject.GetComponent<Rigidbody>().AddForce(Direction, ForceMode.Acceleration);

                if (gameObject.GetComponent<Rigidbody>().velocity.magnitude > maxSpeed) // Limit max speed
                {
                    gameObject.GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(gameObject.GetComponent<Rigidbody>().velocity, maxSpeed);
                }
            }

            if (Input.GetKeyDown(KeyCode.Space) && (myState == StatesOfGrav.OnGravCenter))
            {

                myState = StatesOfGrav.Free; //Change l'etat du player en Free
            }

            if (Input.GetKeyDown(KeyCode.Space) && (myState == StatesOfGrav.IsCleaning))
            {
                if (isGravObject == true)
                {

                    myState = StatesOfGrav.Free; //Change l'etat du player en Free
                }
            }

            if (Input.GetKeyUp(KeyCode.Space) && (myState == StatesOfGrav.Free))
            {
                myState = StatesOfGrav.OnGravCenter; //Change l'etat du player en GravCenter
            }

        }


        if ((myState == StatesOfGrav.IsCleaning))
        {
            if (isGravObject == true)
            {
                if (timeLeft < 0)
                {
                    myState = StatesOfGrav.OnGravCenter; //Change l'etat du player en GravCenter
                }
            }
        }

    }


    private void OnTriggerEnter(Collider other) //Recuperer le transform de l'objet à netoyyer
    {
        if (other.gameObject.CompareTag("OrbitPoint"))
        {
            TargetContact = other.gameObject.GetComponent<Transform>();

            // Au contact dire à l'orbitPlayer quel transform prendre en compte
            OrbitPlayer.target = other.gameObject.GetComponent<Transform>();

            myState = StatesOfGrav.IsCleaning; // Passe en netoyage
        }
        if (other.gameObject.CompareTag("BonusPoints"))
        {
            GameManager.instance.Score += GameManager.instance.AmountBonusPoint;
            Destroy(other.gameObject);
        }
    }

    void MyState() // Gere les Etats
    {
        if (myState == StatesOfGrav.OnGravCenter)
        {
            isGravCenter = true;
            isFree = false;
            isCleanning = false;
            isGravObject = false;
        }

        else if (myState == StatesOfGrav.Free)

        {
            isGravCenter = false;
            isFree = true;
            isCleanning = false;
            isGravObject = false;
        }

        else if (myState == StatesOfGrav.IsCleaning)
        {
            isGravCenter = false;
            isFree = false;
            isCleanning = true;
            isGravObject = true;
        }
    }

}
