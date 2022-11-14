using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer1 : MonoBehaviour
{

    public GameObject player1;

    [SerializeField] Vector3 offset = new Vector3(0, 5, -7);

    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player1.transform.position + offset;
  
    }
}
