using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveInput : MonoBehaviour
{
    public Rigidbody rigid;
    Vector3 moveDir;

    private void OnMove(InputValue value)
    {
        Vector2 inputDir = value.Get<Vector2>();

        moveDir.x = inputDir.x;
        moveDir.z = inputDir.y;

        
    }
    private void OnJump(InputValue value)
    {
        bool inputButton = value.isPressed;

        Jump();
    }

    private void Move()
    {
        transform.position += moveDir * 3f * Time.deltaTime;
    }

    private void Jump()
    {
        rigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
