using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public sound[] sounds;

    // Start is called before the first frame update
    void Awake()
    {
        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        //Play("Start");
    }

    public void Play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Stop(string name) {
        sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
    
    public void stopAll()
    {
        foreach (sound s in sounds)
        {
            s.source.Stop();
        }
    }
}
