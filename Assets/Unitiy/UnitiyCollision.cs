using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitiyCollision : MonoBehaviour
{
    /* �浹ü (Collider)
     * 
     * ������ �浹�� ���� ���ӿ�����Ʈ�� ����� ����
     * ���ӿ�����Ʈ�� ǥ���� �޽ÿ� �Ȱ��� �ʿ�� ����
     * �浹ü�� �浹��Ȳ�� ���� ��� ����Ƽ �浹 �޽����� �޾� ��Ȳ�� Ȯ��
     */

    //<����Ƽ �浹 �޽���>
    // �浹�� �������� ��
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter");
    }
    // �浹 ���϶�
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }
    // �浹�� Ż������ �� 
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit");
    }
    /* Ʈ���� �浹ü
     * 
     * �ϳ��� �浹ü�� �浹�� ����Ű�� �ʰ� �ٸ� �浹ü�� ������ ���� ���� ����
     * Ʈ���Ű� ��ħ��Ȳ�� ���� ��� ����Ƽ Ʈ���� �޽����� �޾� ��Ȳ�� Ȯ��
     */

    // Ʈ���ſ� ��ĥ�� 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
    }

    // Ʈ���ſ� ��ġ�� ���� ��?
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }
    // Ʈ���ſ� ��ģ�� ������ ��
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }


}
