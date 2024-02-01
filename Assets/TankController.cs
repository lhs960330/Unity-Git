using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    public Rigidbody rigid;
    Vector3 moveDir;
    
    public float speed;
    public float moveSpeed;
    public float jump;

    private void OnMove(InputValue value)
    {
        Vector2 imputDir = value.Get<Vector2>();
        moveDir.x = imputDir.x;
        moveDir.z = imputDir.y;

    }
    private void Move()
    {
        
        transform.Translate(0,0, moveDir.z* moveSpeed  * Time.deltaTime);
        Rotate();
    } 

    private void Rotate()
    {
        transform.Rotate(0, moveDir.x * speed * Time.deltaTime, 0);
    }
    private void OnJump(InputValue value)
    {
        bool inputButton = value.isPressed;
        Jump();


    }
    private void Jump()
    {
        rigid.AddForce(Vector3.up * jump, ForceMode.Impulse);
    }


    // Update is called once per frame
    void Update()
    {
        Move();

    }
}
