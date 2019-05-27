using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed; //move speed is float can be changed in unity
    private Vector3 input;
    private void Start()
    {
        
    }

    private void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rigidbody.AddForce(input * moveSpeed);
    }
}
