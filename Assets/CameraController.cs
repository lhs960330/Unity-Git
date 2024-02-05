using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /* public GameObject player;
     private Vector3 offSet;
     // Start is called before the first frame update
     void Start()
     {
         offSet = transform.position - player.transform.position;
     }

     // Update is called once per frame
     void Update()
     {
         transform.position = player.transform.position + offSet;
     }*/
    public Transform follow;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = follow.position+offset;
        transform.LookAt(follow.position);
    }
}
