using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = .1f;
    public AudioSource playerMovementAudio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xposition = Input.GetAxis("Horizontal");
        float yposition = Input.GetAxis("Vertical");

        Vector3 movement = new Vector2(xposition,0);

        transform.Translate(movement * speed * Time.deltaTime);

        if(xposition !=0 || yposition !=0)
        {
            if(!playerMovementAudio.isPlaying) 
                playerMovementAudio.Play();
        } else 
        {
            playerMovementAudio.Stop();
        }
    }
}
