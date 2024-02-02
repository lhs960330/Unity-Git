using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitiyFuniction : MonoBehaviour
{
    [Header("This")]
    public GameObject thisGameObject;
    public string thisName;
    public bool thisActive;
    public string thisTag;
    public int thisLayer;

    [Header("GameObject")]
    public GameObject newGameObject;
    public GameObject destroyGameObject;
    public GameObject findWithName;
    public GameObject findWithTag;

    [Header("Component")]
    // public Component newComponent;
    public Component addComponent;
    public Component destroyComponent;
    public Component getComponent;
    public Component findComponent;
    private void ThisFunction()
    {
        // <���� ���ӿ�����Ʈ ����>
        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� Component�� ������ gameObject �Ӽ��� �̿��Ͽ� ���ٰ���
        thisGameObject = gameObject;         // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ
        thisName = gameObject.name;          // ���ӿ�����Ʈ�� �̸�
        thisActive = gameObject.activeSelf;  // ���ӿ�����Ʈ�� Ȱ��ȭ ���� (activeInHierarchy : ���Ӿ����� Ȱ��ȭ)
        thisTag = gameObject.tag;            // ���ӿ�����Ʈ�� �±�
        thisLayer = gameObject.layer;        // ���ӿ�����Ʈ�� ���̾�
    }
    private void GmaeObjectFunction()
    {
        // ������Ʈ ����


        newGameObject = new GameObject("NewGameObject");

        // ������Ʈ ����
        if (destroyGameObject != null)
        {
            Destroy(destroyGameObject);
        }
        // ������Ʈ ã��
        findWithName = GameObject.Find("Main Camera");  // �̸������� ã�� (�Ⱦ�)
        findWithTag = GameObject.FindWithTag("Player"); // �̸����� ã�°� ���� ������ ȿ�������� ã�´�. 

    }
    private void ComponentFunction()
    {
        //������Ʈ �߰�
        addComponent = gameObject.AddComponent<Rigidbody>();
        // newComponent = new Rigidbody();  // new�ؼ� ����� �ǹ̰� ����, ������Ʈ�� ���ӿ�����Ʈ�� �����Ǿ� �����Ҷ� �ǹ̰� �ִ�.
        // ������Ʈ ����
        if (destroyComponent != null)
        {
            Destroy(destroyComponent);
        }
        // ������Ʈ Ž�� - ���ӿ�����Ʈ���� ã�� - �� ��Ȳ�� ���� ���� ���´�.
        getComponent = gameObject.GetComponent<Collider>();  // �������̽��� ã�� �� �ִ�.

        // ������Ʈ Ž�� - ������ ã��
        findComponent = Component.FindObjectOfType<Camera>();
        


    }
    private void Start()
    {
        ThisFunction();
        GmaeObjectFunction();
        ComponentFunction();
    }
}
