using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGameplay : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip BGM_Gameplay;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }

    
}
