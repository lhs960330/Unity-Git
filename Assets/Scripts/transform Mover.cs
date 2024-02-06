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
        //1번 문제
        /* if (Input.GetKey(KeyCode.Space) && isOk)
         {
             coroutine = StartCoroutine(coolTime());

         }*/
        // 2번 문제
        /*if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(coolTime());
        }*/
        //3번문제
        while (Input.GetKey(KeyCode.Space) && isOk)
        {
            coroutine = StartCoroutine(coolTime());
        }
        /*if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(coroutine);
        }*/

    }

    // 코루틴은 분산처리방식이다.
    // 코루티은 메인 스레드에서 실행한다.
    IEnumerator coolTime()
    {
        // 1번 문제
        /* isOk = false;
         yield return new WaitForSeconds(3f);
         rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);
         isOk = true;*/

        // 2번 문제
        /* rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);
         yield return new WaitForSeconds(1f);
         rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);
         yield return new WaitForSeconds(1f);
         rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);*/

        // 3번 문제

        isOk = false;

        yield return new WaitForFixedUpdate();
        rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);
        yield return new WaitForSeconds(movePower / 4f);
        isOk = true;

    }
}
