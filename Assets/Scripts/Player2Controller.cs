using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    // Private variables
    private float speed = 25f;
    private float turnSpeed = 50f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("HorizontalPlayer2");
        forwardInput = Input.GetAxis("VerticalPlayer2");
        
        // We move the vehicle forward
        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        // We turn the vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        

    }
}
