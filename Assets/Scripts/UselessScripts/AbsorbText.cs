using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbText : MonoBehaviour {

    // Blends between two materials
    
    //public List <Material> materialsBank;
    public Material material1;
    public Material material2;
    public Rigidbody MarbbleRdB;
    //Creation de variable de type rendu
    Renderer rend;

    // Vitesse du Clamp
    float absorb = 0f;

    // Durée du Clamp
    float duration = 4.0f;

    float lerp;

    //random pour le changement de matériaux
    int rand;


    

    void Start()
    {
        // Lance le random au start
       // rand = Random.Range(0, materialsBank.Count);

        // Variable rend prend les paramètres du composant "renderer" de l'objet auquel le script est associé
        rend = GetComponent<Renderer>();

        

        // At start, use the first material + en prenant en compte la valeur du random lancé avant   

        //material1 = materialsBank[rand];
        rend.material = material1;

    }

    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        { 
            // MarbbleRdB = other.gameObject.GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Clamp between the materials over the duration
           
            lerp = Mathf.Clamp(absorb, 0f, duration) / duration;
            rend.material.Lerp(material1, material2, lerp);
            absorb += 0.07f;

            if (duration == 4f)
            {
               // MarbbleRdB.velocity = Vector3.zero;
            
            }
        }
    }




}


