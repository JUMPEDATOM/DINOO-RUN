using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    
    void Awake() // just like start but called before!
    {
      foreach (Sound s in sounds) // for loop throw our all sound to find
      {
        s.source = gameObject.AddComponent<AudioSource>(); // create audio source component // "s" is the audio that we are looking for
        s.source.clip = s.clip;
        s.source.volume = s.volume;
        s.source.pitch = s.pitch;
        s.source.loop = s.loop;
      }    
    }

    public void Play (string name) // for play the sound
    {
      // for find the sound with appoporite name!
      Sound s = Array.Find(sounds, sound => sound.name == name);
      if (s == null)
      {
        return;
      }
      s.source.Play();
    }
}
