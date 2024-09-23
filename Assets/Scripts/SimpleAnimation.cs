using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleAnimation : MonoBehaviour
{
    public Sprite[] spritesToAnimate;
    

    private int currentFrame = 0; //which frame we're currently on
    private float timeSinceCurrentFrame; //how much time have we been displaying the current frame so far?
    public float eachFrameDuration = 0.15f; //how long each frame is displayed for. (remember whatever is in the Inspector will override this value!)
    
    private float animationLoopDuration; // how long is the complete animation? (this will depend on how many frames there are)
    
    // Start is called before the first frame update
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
		//call our AdvanceTime function
        if(Input.GetKey(KeyCode.D))
        {
		    AdvanceTime(Time.deltaTime);
        }
        else 
        {
            for(int i=0;i<spritesToAnimate.Length;i++)
            {
                if(i == 0)
                {
                    GetComponent<SpriteRenderer>().sprite = spritesToAnimate[0];
                }
            }
        }
    }


    /// <summary>
    /// advance the animation by a duration in seconds, advancing as many
    /// frames as necessary
    /// </summary>
    private void AdvanceTime(float duration)
    {
        timeSinceCurrentFrame += duration;
        
        while (timeSinceCurrentFrame > eachFrameDuration && eachFrameDuration > 0)
        {
            timeSinceCurrentFrame = timeSinceCurrentFrame - eachFrameDuration;


            ShowNextFrame();
        }
    }





     /// <summary>
    /// advance the animation by one frame, looping if necessary
    /// </summary>
    private void ShowNextFrame()
    {
        currentFrame += 1;


        // looping
        if (currentFrame >= spritesToAnimate.Length)
        {
            currentFrame = 0;
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
