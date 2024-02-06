using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject newGameObject;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Bullet")
        {
           
            Destroy(gameObject);
        }
    }
}
