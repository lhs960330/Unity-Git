using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitiyTransform : MonoBehaviour
{
    /* Ʈ������
     * 
     * ���ӿ�����Ʈ�� ��ġ, ȸ��, ũ�⸦ �����ϴ� ������Ʈ
     * ���ӿ�����Ʈ�� �θ�-�ڽ� ���¸� �����ϴ� ������Ʈ
     * ���ӿ�����Ʈ�� �ݵ�� �ϳ��� Ʈ������ ������Ʈ�� ������ ������ �߰� & ������ �� ����
     */
    public Transform thisTransform;

    // ����
    private void TransformReference()
    {
        thisTransform = transform;
    }

    // �̵�
    private void Translate()
    {
        // ���� ������ ������ �Ǿ��ִ�.
        // �ڱ��ڽ��� ���ؿ����� ��ǥ��
        transform.Translate(1, 0, 0, Space.Self);
        // ���� ���ؿ� ��ǥ��
        transform.Translate(1, 0, 0, Space.World);

        // �������� �̿��� �̵�
        transform.position += new Vector3(1, 0, 0);
    }

    // ȸ��
    private void Rotate()
    {
        // ���� �������� ȸ��
        transform.Rotate(Vector3.up, 30, Space.World);
        // �ڽ��� �������� ȸ��
        transform.Rotate(Vector3.up, 30, Space.Self);
        // ��ǥ�� �������� ȸ��
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30);
        // ��ǥ�� �ٶ󺸴� ȸ��
        transform.LookAt(new Vector3(0, 0, 0));

    }

    // Ʈ���� ��
    private void Axis()
    {
        // Ʈ�������� x��
        Vector3 right = transform.right;

        // Ʈ�������� y��
        Vector3 up = transform.up;

        // Ʈ�������� z��
        Vector3 forward = transform.forward;
    } 


    private void Update()
    {
        
    }
}