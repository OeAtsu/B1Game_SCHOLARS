using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAbsorb : MonoBehaviour {

    // Blends between two materials
    
    //public List <Material> materialsBank;
    public Material material1;
    public Material material2;
    private CleanningOrbitObject OrbitPlayer;
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

    void Start()
    {
    
        // Variable rend prend les paramètres du composant "renderer" de l'objet auquel le script est associé
        rend = GetComponent<Renderer>();

        // At start, prend le premier material
        rend.material = material1;

    }

    void Update()
    {
        if (lerp == 1f) // Pour se faire rattraper par le centre
        {
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
            Debug.Log("c'est fait");
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


