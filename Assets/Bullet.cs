using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rigid;
    public float force;

    private void Start()
    {
        // 총알이 5초뒤에 사라짐
        Destroy(gameObject, 5f);

        rigid.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
