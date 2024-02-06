using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spin : MonoBehaviour
{

    public float spinSpeed;
    Vector3 vector3;


    private void OnSpin(InputValue value)
    {
        Vector2 imputDir = value.Get<Vector2>();
        vector3.x = imputDir.x;
        vector3.y = imputDir.y;
    }
    private void Rotate()
    {

        transform.Rotate(Vector3.up, vector3.x * spinSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.right, -vector3.y * spinSpeed * Time.deltaTime, Space.Self);

    }
    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
}
