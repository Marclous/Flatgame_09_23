using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowRigid : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PlayerObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerObject.transform.position.x, PlayerObject.transform.position.y,-10);
    }

    /*private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(
            transform.position,
            PlayerObject.transform.position + offset,
            ref currentVelocity,
            smoothTime
            )
    }*/
}
