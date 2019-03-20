using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAbsorb : MonoBehaviour {

    // Blends between two materials
    
    //public List <Material> materialsBank;
    public Material material1;
    public Material material2;
    private CleanningOrbitObject OrbitPlayer;
    public float distanceScore;
    //Creation de variable de type rendu
    Renderer rend;

    // Vitesse du Clamp
    float absorb = 0f;

    // Durée du Clamp
    public float duration = 4.0f;

    //Etat du Lerp
    public float lerp;

    //CoolDown
    public float timeStamp;

    //Score
    public bool isAlreadyScored = false;
    public int ToInt;

    void Start()
    {
        distanceScore = Vector3.Distance(GravityObjectManager.instance.transform.position,transform.position);
        // Variable rend prend les paramètres du composant "renderer" de l'objet auquel le script est associé
        rend = GetComponent<Renderer>();

        // At start, prend le premier material
        rend.material = material1;

    }

    void Update()
    {
        if (lerp == 1f) // Pour se faire rattraper par le centre et score
        {
            if (isAlreadyScored == false)
            {
                ToInt = (int)(distanceScore * 1.2f);
                GameManager.instance.Score += ToInt; 
                isAlreadyScored = true;
            }
           

            PlayerManager.instance.timeLeft -= Time.deltaTime; // lance le timer
            if (PlayerManager.instance.timeLeft < 0)
            {
                lerp = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Contact avec Player
        {

            PlayerManager.instance.timeLeft = 5f;
            OrbitPlayer = other.gameObject.GetComponent<CleanningOrbitObject>(); // prend le transform sur lequel orbiter
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Contact avec Player
        {
            // Clamp des deux materials sur la durée
           
            lerp = Mathf.Clamp(absorb, 0f, duration) / duration;
            rend.material.Lerp(material1, material2, lerp);
            absorb += 0.07f;
            
        }
    }
}


