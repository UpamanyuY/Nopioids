using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;


public class LB_audioManager : MonoBehaviour {

    public LB_sound[] sounds;


    public static LB_audioManager instance;

    public float volume;

	// Use this for initialization
	void Awake () 
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy (gameObject);
            return;
        }

        DontDestroyOnLoad (gameObject);

	    foreach (LB_sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource> ();
            s.source.clip = s.clip;

            s.source.volume = s.volume * volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    	
	}

    private void Start ()
        {
        Play ("Theme");
        }

    public void Play (string clipName)
        {
            LB_sound s = Array.Find (sounds, sound => sound.clipName == clipName);
                if (s == null)
                {
                     Debug.LogWarning ("Sound: " + clipName + " not found!");
                     return;
                 }

            s.source.Play ();
        }
 
}
