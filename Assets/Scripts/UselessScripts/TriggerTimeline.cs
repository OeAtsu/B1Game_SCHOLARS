using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour {

    

        public PlayableDirector playableDirector;
        private void OnTriggerEnter(Collider other){

        playableDirector.Play();

        }
    
}
   
    

