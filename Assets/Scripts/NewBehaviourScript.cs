using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject newGameObject;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌1");
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("충돌2");
            Destroy(gameObject);
        }
    }
}
