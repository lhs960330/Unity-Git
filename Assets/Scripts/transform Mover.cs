using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class transformMover : MonoBehaviour
{
    /* [SerializeField] Rigidbody rigid;
     private float coolTime = 2f;


     private void Update()
     {
         coolTime += Time.deltaTime;

         if(coolTime >= 2f && Input.GetKeyDown(KeyCode.Space))
         {
             rigid.AddForce(Vector3.up * 5f,ForceMode.Impulse);
             coolTime = 0f;
         }
     }*/
    Transform tramsForm;
    [SerializeField] float speed;
    [SerializeField] Rigidbody rigid;
    [SerializeField] float movePower;
    private Coroutine coroutine;
    bool isOk = true;
    Vector3 pos;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);

        }
        //1�� ����
        /* if (Input.GetKey(KeyCode.Space) && isOk)
         {
             coroutine = StartCoroutine(coolTime());

         }*/
        // 2�� ����
        /*if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(coolTime());
        }*/
        //3������
        while (Input.GetKey(KeyCode.Space) && isOk)
        {
            coroutine = StartCoroutine(coolTime());
        }
        /*if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(coroutine);
        }*/

    }

    // �ڷ�ƾ�� �л�ó������̴�.
    // �ڷ�Ƽ�� ���� �����忡�� �����Ѵ�.
    IEnumerator coolTime()
    {
        // 1�� ����
        /* isOk = false;
         yield return new WaitForSeconds(3f);
         rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);
         isOk = true;*/

        // 2�� ����
        /* rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);
         yield return new WaitForSeconds(1f);
         rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);
         yield return new WaitForSeconds(1f);
         rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);*/

        // 3�� ����

        isOk = false;

        yield return new WaitForFixedUpdate();
        rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);
        yield return new WaitForSeconds(movePower / 4f);
        isOk = true;

    }
}
