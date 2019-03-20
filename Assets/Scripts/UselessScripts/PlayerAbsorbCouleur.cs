using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbsorbCouleur : MonoBehaviour
{

    // Blends between two materials

    
    public Material material3;
    public Material material4;


    
    // Creation de variables pour création d'une nouvelle matière
    Shader shader;
    Texture texture;
    Color color;

    //Creation de variable de rendu
    Renderer rend;

    // Vitesse du Clamp
    public float absorb = -1f;

    // Durée du Clamp
    public float duration = 1.0f;

    public float lerp;

        void Start()
    {
    

        // Variable rend prend les paramètres du composant "renderer" de l'objet auquel le script est associé
        rend = GetComponent<Renderer>();

        // At start, use the first material
        rend.material = material3;

    }

    void Update()
    {
        if (lerp == 0f)
        {
            //Debug.Log("RESET");
        }
    }
    
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plateforme"))
        {
            //Debug.Log("Rentre"+absorb);
            absorb = 0f;

            material3.color = material4.color;

            material4.color = other.gameObject.GetComponentInParent<Renderer>().material.color;

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Plateforme"))
        {
            //Debug.Log("Reste" + absorb);
            

            lerp = Mathf.Clamp(absorb, 0f, duration) / duration;
            rend.material.Lerp(material3, material4, lerp);
            absorb += 0.07f;


        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Plateforme"))
        {
            Debug.Log("sort" + absorb);
            
            
            


        }
    }
}


