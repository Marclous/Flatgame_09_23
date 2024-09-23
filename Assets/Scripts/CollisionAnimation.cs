using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collided : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] spritesToAnimate;
    private int currentFrame = 0; //which frame we're currently on
    private float timeSinceCurrentFrame; //how much time have we been displaying the current frame so far?
    public float eachFrameDuration = 0.15f; //how long each frame is displayed for. (remember whatever is in the Inspector will override this value!)
    
    private float animationLoopDuration; // how long is the complete animation? (this will depend on how many frames there are)
    
    void Start()
    {
        animationLoopDuration = spritesToAnimate.Length * eachFrameDuration;

        //loop through each element of the spritesToAnimate array, and set all 
        // the associated gameObjects to SetActive false (inactive)

        GetComponent<SpriteRenderer>().sprite = spritesToAnimate[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Triggered with" + other.gameObject.name);
        if(other.gameObject.name == "Player") {
            ShowNextFrame();
        }
        
    }


    private void ShowNextFrame()
    {
        currentFrame += 1;


        // looping
        if (currentFrame >= spritesToAnimate.Length)
        {
            currentFrame = 1;
        }


         for(int i=0;i<spritesToAnimate.Length;i++)
         {
            if(i == currentFrame)
            {
                 GetComponent<SpriteRenderer>().sprite = spritesToAnimate[i];
            }
           
         }
    }

}
