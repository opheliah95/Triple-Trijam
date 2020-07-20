using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public void PlaySound(AudioClip sound)
    {
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().clip = sound;
        GetComponent<AudioSource>().Play();
    }

    public void PlaySound(SoundData soundData)
    {
        int index = Random.Range(0, soundData.sounds.Count);
        AudioClip clip = soundData.sounds[index];
        PlaySound(clip);
    }

    public void StopSound()
    {
        GetComponent<AudioSource>().Stop();
    }
}
