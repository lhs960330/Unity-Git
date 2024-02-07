using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitiyTransform : MonoBehaviour
{
    /* 트랜스폼
     * 
     * 게임오브젝트이 위치, 회전, 크기를 저장하는 컴포넌트
     * 게임오브젝트의 부모-자식 상태를 저장하는 컴포넌트
     * 게임오브젝트는 반드시 하나의 트랜스폼 컴포넌트를 가지고 있으며 추가 & 제거할 수 없음
     */
    public Transform thisTransform;

    // 접근
    private void TransformReference()
    {
        thisTransform = transform;
    }

    // 이동
    private void Translate()
    {
        // 쓰지 않으면 셀프로 되어있다.
        // 자기자신의 기준에서의 좌표로
        transform.Translate(1, 0, 0, Space.Self);
        // 월드 기준에 좌표로
        transform.Translate(1, 0, 0, Space.World);

        // 포지션을 이용한 이동
        transform.position += new Vector3(1, 0, 0);
    }

    // 회전
    private void Rotate()
    {
        // 월드 기준으로 회전
        transform.Rotate(Vector3.up, 30, Space.World);
        // 자신을 기준으로 회전
        transform.Rotate(Vector3.up, 30, Space.Self);
        // 좌표를 기준으로 회전
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30);
        // 좌표를 바라보는 회전
        transform.LookAt(new Vector3(0, 0, 0));

    }

    // 트랜스 축
    private void Axis()
    {
        // 트랜스폼의 x축
        Vector3 right = transform.right;

        // 트랜스폼의 y축
        Vector3 up = transform.up;

        // 트랜스폼의 z축
        Vector3 forward = transform.forward;
    } 


    private void Update()
    {
        
    }
}