using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = .1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xposition = Input.GetAxis("Horizontal");
        float yposition = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xposition, yposition, 0);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
