﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour {

    public PlayableDirector playableDirector;
    
    
        public void play() {

        playableDirector.Play();

        }
    }

