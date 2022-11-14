using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{

    public GameObject player2;
    Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {  
        transform.position = player2.transform.position + offset;   
    }
}
