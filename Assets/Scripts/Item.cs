using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // �̷��� ���̶� �����ϰԵǸ� ����� 
        /*Debug.Log("������ȹ��");
        Destroy(gameObject);*/
        // �̷��� �����ϰ� ����� �ٸ��Ͱ� �浹�ص� ������� �ʴ´�.
        // ���� : �̷������� �浹�ϸ� �ݹ߷��� ����
        /*if (collision.gameObject.tag == "Player")
        {
            Debug.Log("������ȹ��");
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

