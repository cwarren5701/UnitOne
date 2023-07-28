using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    // private variables
    private float speed = 20;
    private float turnSpeed = 35;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get and initialize inputs
        horizontalInput = Input.GetAxis("HorizontalAlt");
        forwardInput = Input.GetAxis("VerticalAlt");

        // translate and rotate player based on inputs
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
