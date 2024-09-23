using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.name == "Player"&&!audioSource.isPlaying) {
            audioSource.Play();
        }
    }
}
