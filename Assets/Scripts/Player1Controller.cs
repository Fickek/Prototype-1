using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    // Private variables
    [SerializeField] float speed = 25f;
    [SerializeField] float horsepower = 25f;
    public const float turnSpeed = 50f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // We move the vehicle forward
        //transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        playerRb.AddRelativeForce(Vector3.forward * horsepower * forwardInput);

        // We turn the vehicle 
        //transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);



    }
}
