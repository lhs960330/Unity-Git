using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    public Transform firePoint;
    public Bullet bulletPrefab;
    public float bulletForce;

    // ������
    Vector3 moveDir;
    public float speed;
    public float movePower;
    public float jump;
    public Rigidbody rigid;
    public float maxSpeed;

    // ī�޶�
    public CinemachineVirtualCamera normalCamera;
    public CinemachineVirtualCamera ZoomCamera;

    // ����
    public AudioSource audioSource;

    // �ִϸ��̼�
    public Animator animator;



    private void OnZoom(InputValue value)
    {
        if (value.isPressed)
        {
            ZoomCamera.Priority = 20;
        }
        else
        {
            ZoomCamera.Priority = 0;
        }
    }
    private void OnMove(InputValue value)
    {
        Vector2 imputDir = value.Get<Vector2>();
        moveDir.x = imputDir.x;
        moveDir.z = imputDir.y;

    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        Vector3 forceDir = transform.forward * moveDir.z;
        rigid.AddForce(forceDir * movePower, ForceMode.Force);

        // AddForce�� ����Ҷ��� �ӵ� ���� ���
        if (rigid.velocity.magnitude > maxSpeed)
        {
            rigid.velocity = rigid.velocity.normalized * maxSpeed;

        }
        //transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime);

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

    Coroutine Coroutine;
    private void OnFire(InputValue value)
    {
        StartCoroutine(FireCoroutine());
    }
    public void Fire()
    {
        audioSource.Play();
        // �������� �����߿� ������ִ� �Լ�
        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.force = bulletForce;
        animator.SetTrigger("Fire");
    }

    IEnumerator FireCoroutine()
    {
        bulletForce = 10f;
        float strat = Time.time;
        yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.E));
        float end = Time.time;
        bulletForce += bulletForce + (end - strat) * 3;
        Fire();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
}