using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;


public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;


    public static AudioManager instance;

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

        foreach (Sound s in sounds)
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
        Play ("ACLoop");
        Play ("BeepLoop");
    }

    public void Play (string clipName)
    {
        Sound s = Array.Find (sounds, sound => sound.clipName == clipName);
        if (s == null)
        {
            Debug.LogWarning ("Sound: " + clipName + " not found!");
            return;
        }

        s.source.Play ();
    }

}
