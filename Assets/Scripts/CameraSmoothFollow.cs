using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothFollow : MonoBehaviour
{
    public Vector3 offset = new Vector3 (2, 8, -10);
    public float smoothTime = 0.25f;
    public GameObject PlayerObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector3 currentVelocity;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(
            transform.position,
            PlayerObject.transform.position + offset,
            ref currentVelocity,
            smoothTime
            );
    }
}
