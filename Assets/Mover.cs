using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float movePower;
    public float moveUp;
    public Rigidbody rigid;
    public bool isOk = false;
    // Update´Â 
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(Vector3.forward * movePower);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(Vector3.back * movePower);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(Vector3.left * movePower);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(Vector3.right * movePower);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOk == true)
        {
            isOk = false;
            rigid.AddForce(Vector3.up * moveUp, ForceMode.Impulse);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        isOk = true;
    }
}
