using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject newGameObject;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹1");
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("�浹2");
            Destroy(gameObject);
        }
    }
}
