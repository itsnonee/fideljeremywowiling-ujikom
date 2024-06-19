using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip BGM_MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }
}
