using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover1 : MonoBehaviour
{    
    public float movePower;
    public Rigidbody rigid;

    // Update´Â 
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid.AddForce(Vector3.forward * movePower);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigid.AddForce(Vector3.back * movePower);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigid.AddForce(Vector3.left * movePower);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigid.AddForce(Vector3.right * movePower);
        }

    }
}
