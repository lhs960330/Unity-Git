using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;    

    // 움직임
    Vector3 moveDir;
    public float speed;
    public float moveSpeed;
    public float jump;
    public Rigidbody rigid;

    private void OnMove(InputValue value)
    {
        Vector2 imputDir = value.Get<Vector2>();
        moveDir.x = imputDir.x;
        moveDir.z = imputDir.y;

    }
    private void Move()
    {
        transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime);
        
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
    
    private void OnFire(InputValue value)
    {
        Fire();
    }
    private void Fire()
    {
        // 프리팹을 실행중에 만들어주는 함수
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }
}
