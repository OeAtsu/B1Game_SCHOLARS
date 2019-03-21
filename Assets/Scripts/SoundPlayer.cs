using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPlayer : MonoBehaviour {


    public AudioSource Voice;
    public AudioSource Musique;
    public AudioSource SFX;

    public AudioClip[] VoiceAudioClips;
    public AudioClip[] MusiqueAudioClips;
    public AudioClip[] SFXAudioClips;

    public bool voice1 = true, voice2 = true, voice3 = true, voice4 = true, voice5 = true, voice6 = true, voice7 = true, voice8 = true, voice9 = true, voice10 = true, voice11 = true, voice12 = true; 
    public float Timer;
    public float starttimer = 0f;

    public Text Soustitre;
    public Animator soustitreanim;


    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        Timer = GameManager.instance.timer;
        if (Timer == 300)
        {
            starttimer += Time.deltaTime;
            if (starttimer > 0.5f && starttimer < 1.5f)
            {
                Soustitre.text = ("Initialisation. Verification du rapport precedent etabli il y a dix ans.");
                soustitreanim.SetBool("showtext5s", true);
                if (starttimer > 1f)
                {
                    soustitreanim.SetBool("showtext5s", false);
                }
            }

            if (starttimer > 7.5f && starttimer < 8.5f)
            {
                Soustitre.text = ("Rapport verifie. ");
                soustitreanim.SetBool("showtext2s", true);
                if (starttimer > 8f)
                {
                    soustitreanim.SetBool("showtext2s", false);
                }
            }

            if (starttimer > 11f && starttimer < 12f)
            {
                Soustitre.text = ("compte a rebours configure sur 5 minutes. en attente de l'impulsion.");
                soustitreanim.SetBool("showtext5s", true);
                if (starttimer > 11.5f)
                {
                    soustitreanim.SetBool("showtext5s", false);
                }
            }
        }
        
        if (Timer < 299f && Timer >298)
        {
            Soustitre.text = ("Ejection : succes");
            soustitreanim.SetBool("showtext2s", true);
            if (Timer < 298.5f)
            {
                soustitreanim.SetBool("showtext2s", false);
            }
        }

        if ((!Musique.isPlaying) && Timer < 250f)
        {
            Musique.clip = MusiqueAudioClips[2];
            Musique.Play();
        }
       

        if (Timer < 299.9 && voice1 == true)
        {
            Voice.clip = VoiceAudioClips[1];
            Voice.Play();
            Musique.clip = MusiqueAudioClips[1];
            Musique.Play();
            voice1 = false;
        }





        if (Timer < 270 && voice4 == true)
        {
            Voice.clip = VoiceAudioClips[4];
            Voice.Play();
            voice4 = false;
        }
        if (Timer < 270f && Timer > 269f)
        {
            Soustitre.text = ("156: Message pour la terre: mission debutee, tentative de communication");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 269.5f)
            {
                soustitreanim.SetBool("showtext5s", false);
            }
        }

        if (Timer < 264f && Timer > 263f)
        {
            Soustitre.text = ("Tentative de communication echouee");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 263.5f)
            {
                soustitreanim.SetBool("showtext3s", false);
            }
        }






        if (Timer < 240 && voice5 == true)
        {
            Voice.clip = VoiceAudioClips[5];
            Voice.Play();
            voice5 = false;
        }
        if (Timer < 240f && Timer > 239f)
        {
            Soustitre.text = ("156: Second message: destinataire, Terre. reponse demandee, Termine.");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 239.5f)
            {
                soustitreanim.SetBool("showtext5s", false);
            }
        }

        if (Timer < 234f && Timer > 233f)
        {
            Soustitre.text = ("Tentative de communication echouee");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 233.5f)
            {
                soustitreanim.SetBool("showtext3s", false);
            }
        }







        if (Timer < 190 && voice6 == true)
        {
            Voice.clip = VoiceAudioClips[6];
            Voice.Play();
            voice6 = false;
        }
        if (Timer < 190f && Timer > 189f)
        {
            Soustitre.text = ("156: 1, tu as une reponse de la Terre?");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 189.5f)
            {
                soustitreanim.SetBool("showtext5s", false);
            }
        }

        if (Timer < 185.2f && Timer > 184.2f)
        {
            Soustitre.text = ("1: Negatif, pourtant ils le recoivent");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 184.7f)
            {
                soustitreanim.SetBool("showtext3s", false);
            }
        }







        if (Timer < 160 && voice7 == true)
        {
            Voice.clip = VoiceAudioClips[7];
            Voice.Play();
            voice7 = false;
        }

        if (Timer < 160f && Timer > 159f)
        {
            Soustitre.text = ("156: Tu pense que... Ils nous ont oublies ?");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 159.5f)
            {
                soustitreanim.SetBool("showtext3s", false);
            }
        }

        if (Timer < 157f && Timer > 156f)
        {
            Soustitre.text = ("1: impossible, ils attendent chaque decennie notre reveil avec impatience");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 156.5f)
            {
                soustitreanim.SetBool("showtext5s", false);
            }
        }







        if (Timer < 130 && voice8 == true)
        {
            Voice.clip = VoiceAudioClips[8];
            Voice.Play();
            voice8 = false;
        }


        if (Timer < 130f && Timer > 129f)
        {
            Soustitre.text = ("332: Marbles, je suis tombe sur Terre, aucun signe de vie sur mes capteurs");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 129.5f)
            {
                soustitreanim.SetBool("showtext5s", false);
            }
        }

        if (Timer < 125f && Timer > 124f)
        {
            Soustitre.text = ("1: Ils... Tes capteurs doivent etre endommages");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 124.5f)
            {
                soustitreanim.SetBool("showtext3s", false);
            }
        }

        if (Timer < 122f && Timer > 121f)
        {
            Soustitre.text = ("332: Non, ils sont intacts, je relance un scan");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 121.5f)
            {
                soustitreanim.SetBool("showtext3s", false);

            }
        }

        if (Timer < 119f && Timer > 118f)
        {
            Soustitre.text = ("156: On a deux minutes, peut etre ont ils des problemes de reseau");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 118.5f)
            {
                soustitreanim.SetBool("showtext5s", false);

            }
        }









        if (Timer < 95 && voice9 == true)
        {
            Voice.clip = VoiceAudioClips[9];
            Voice.Play();
            voice9 = false;
        }

        if (Timer < 95f && Timer > 94f)
        {
            Soustitre.text = ("?: spaaaaaaaaaaaaaaace");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 94.5f)
            {
                soustitreanim.SetBool("showtext3s", false);

            }
        }
        if (Timer < 90f && Timer > 89f)
        {
            Soustitre.text = ("1: bon... certains marbles deviennent fous a ce que je vois..");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 89.5f)
            {
                soustitreanim.SetBool("showtext5s", false);

            }
        }
        if (Timer < 85f && Timer > 84f)
        {
            Soustitre.text = ("156: Toujours aucune reponse des Hommes ?");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 84.5f)
            {
                soustitreanim.SetBool("showtext3s", false);

            }
        }
        if (Timer < 82f && Timer > 81f)
        {
            Soustitre.text = ("1: Non.. Rien, on ne perd pas espoir et on continue notre travail");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 81.5f)
            {
                soustitreanim.SetBool("showtext5s", false);

            }
        }

        if (Timer < 79f && Timer > 78f)
        {
            Soustitre.text = ("156: Ok          122: Ok       741: Oui");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 78.5f)
            {
                soustitreanim.SetBool("showtext5s", false);

            }
        }






        if (Timer < 60 && voice10 == true)
        {
            Voice.clip = VoiceAudioClips[10];
            Voice.Play();
            voice10 = false;
        }

        if (Timer < 60f && Timer > 59f)
        {
            Soustitre.text = ("1 minute avant desactivation");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 59.5f)
            {
                soustitreanim.SetBool("showtext3s", false);

            }
        }

        if (Timer < 57f && Timer > 56f)
        {
            Soustitre.text = ("Encore Rien... P***");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 56.5f)
            {
                soustitreanim.SetBool("showtext3s", false);

            }
        }





        if (Timer < 30 && voice11 == true)
        {
            Voice.clip = VoiceAudioClips[11];
            Voice.Play();
            voice11 = false;
        }
        if (Timer < 30f && Timer > 29f)
        {
            Soustitre.text = ("30 secondes avant desactivation");
            soustitreanim.SetBool("showtext3s", true);
            if (Timer < 29.5f)
            {
                soustitreanim.SetBool("showtext3s", false);

            }
        }
        if (Timer < 27f && Timer > 26f)
        {
            Soustitre.text = ("122: Travail termine");
            soustitreanim.SetBool("showtext1s", true);
            if (Timer < 26.5f)
            {
                soustitreanim.SetBool("showtext1s", false);

            }
        }
        if (Timer < 25f && Timer > 24f)
        {
            Soustitre.text = ("1: Beau travail, je reste fonctionnel pour recevoir une repone Humaine");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 24.5f)
            {
                soustitreanim.SetBool("showtext5s", false);

            }
        }








        if (Timer < 11 && voice12 == true)
        {
            Voice.clip = VoiceAudioClips[12];
            Voice.Play();
            voice12 = false;
        }
        if (Timer < 11f && Timer > 10f)
        {
            Soustitre.text = ("10, 9, 8, 7, 6, 5, 4..");
            soustitreanim.SetBool("showtext5s", true);
            if (Timer < 10.5f)
            {
                soustitreanim.SetBool("showtext5s", false);

            }
        }

        if (Timer < 3f && Timer > 2f)
        {
            Soustitre.text = ("3,2, 1...");
            soustitreanim.SetBool("showtext2s", true);
            if (Timer < 2.5f)
            {
                soustitreanim.SetBool("showtext2s", false);

            }
        }
        if (Timer < 1f && Timer > 0.1f)
        {
            Soustitre.text = ("Deconnexion");
            soustitreanim.SetBool("showtext2s", true);
            if (Timer < 0.5f)
            {
                soustitreanim.SetBool("showtext2s", false);

            }
        }
    }
}
