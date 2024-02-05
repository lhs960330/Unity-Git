using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitiyCollision : MonoBehaviour
{
    /* 충돌체 (Collider)
     * 
     * 물리적 충돌을 위해 게임오브젝트의 모양을 정의
     * 게임오브젝트의 표현인 메시와 똑같을 필요는 없음
     * 충돌체가 충돌상황에 있을 경우 유니티 충돌 메시지를 받아 상황을 확인
     */

    //<유니티 충돌 메시지>
    // 충돌에 진입했을 때
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter");
    }
    // 충돌 중일때
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }
    // 충돌에 탈출했을 때 
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit");
    }
    /* 트리거 충돌체
     * 
     * 하나의 충돌체가 충돌을 일으키지 않고 다른 충돌체의 공간에 들어가는 것을 감지
     * 트리거가 겹침상황에 있을 경우 유니티 트리거 메시지를 받아 상황을 확인
     */

    // 트리거와 겹칠때 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
    }

    // 트리거와 겹치고 있을 때?
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }
    // 트리거와 겹친게 끝났을 때
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }


}
