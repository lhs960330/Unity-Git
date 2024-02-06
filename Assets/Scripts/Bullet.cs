using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rigid;
    public float force;
    public GameObject explosionEffect;
    private void Start()
    {
        // �Ѿ��� 5�ʵڿ� �����
        Destroy(gameObject, 5f);

        rigid.AddForce(transform.forward * force, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);        
    }
}
