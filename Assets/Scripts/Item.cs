using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // 이러면 땅이랑 접촉하게되면 사라짐 
        /*Debug.Log("아이템획득");
        Destroy(gameObject);*/
        // 이렇게 지정하게 만들면 다른것과 충돌해도 사라지지 않는다.
        // 단점 : 이런식으로 충돌하면 반발력이 생김
        /*if (collision.gameObject.tag == "Player")
        {
            Debug.Log("아이템획득");
            Destroy(gameObject);
        }*/
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
        }
    }
}

