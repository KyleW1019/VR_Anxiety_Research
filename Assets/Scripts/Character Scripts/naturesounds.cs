using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class naturesounds : MonoBehaviour
{
    public AudioClip ac;

    private IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = ac;
        audio.Play();
    }
}
