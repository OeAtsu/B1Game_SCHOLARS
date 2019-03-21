using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {


    public AudioSource Voice;
    public AudioSource Musique;
    public AudioSource SFX;

    public AudioClip[] VoiceAudioClips;
    public AudioClip[] MusiqueAudioClips;
    public AudioClip[] SFXAudioClips;

    public bool voice1 = true, voice2 = true, voice3 = true, voice4 = true, voice5 = true, voice6 = true, voice7 = true, voice8 = true, voice9 = true, voice10 = true, voice11 = true, voice12 = true; 

    public float Timer;


    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        Timer = GameManager.instance.timer;

        if ((!Musique.isPlaying) && Timer < 250f)
        {
            Musique.clip = MusiqueAudioClips[2];
            Musique.Play();
        }

        if (Timer < 299 && voice1 == true)
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

        if (Timer < 240 && voice5 == true)
        {
            Voice.clip = VoiceAudioClips[5];
            Voice.Play();
            voice5 = false;
        }

        if (Timer < 190 && voice6 == true)
        {
            Voice.clip = VoiceAudioClips[6];
            Voice.Play();
            voice6 = false;
        }

        if (Timer < 160 && voice7 == true)
        {
            Voice.clip = VoiceAudioClips[7];
            Voice.Play();
            voice7 = false;
        }

        if (Timer < 130 && voice8 == true)
        {
            Voice.clip = VoiceAudioClips[8];
            Voice.Play();
            voice8 = false;
        }

        if (Timer < 100 && voice9 == true)
        {
            Voice.clip = VoiceAudioClips[9];
            Voice.Play();
            voice9 = false;
        }

        if (Timer < 70 && voice10 == true)
        {
            Voice.clip = VoiceAudioClips[10];
            Voice.Play();
            voice10 = false;
        }

        if (Timer < 40 && voice11 == true)
        {
            Voice.clip = VoiceAudioClips[11];
            Voice.Play();
            voice11 = false;
        }

        if (Timer < 10 && voice12 == true)
        {
            Voice.clip = VoiceAudioClips[12];
            Voice.Play();
            voice12 = false;
        }
    }
}
