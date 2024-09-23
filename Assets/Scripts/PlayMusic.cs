using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void PlaySound() {
        if(!audioSource.isPlaying) {
            audioSource.Play();
        }
    }
}
