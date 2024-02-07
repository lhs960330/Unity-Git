using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private static Manager instance;
    [SerializeField] GameManager gameManager;
    [SerializeField] DataManager dataManager;
    public static Manager GetInstance() { return instance; }
    public static GameManager Game { get { return instance.gameManager; } }
    public static DataManager DataManager { get {  return instance.dataManager; } }
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Singleton already exist");
            Destroy(this); //�̹� ������ �����ִ� ������� �������
            return;
        }
        instance = this; // ���ο� ģ���� this�� ����

        DontDestroyOnLoad(this);  // �ٸ� ���� ���� ���� �ְ� ������ִ� �Լ�
    }

    private void OnDestroy()
    {
        // �ν��Ͻ��� ������� null�ٲ��ش�.
        if (instance == this)
        {
            instance = null;
        }
    }

    // �̱����� �̿��� ��� ����
    // ��ũ�� �� źȯ�� �� ������ �����ߴ�.
    // �Ŵ��� ��ü�� �����ϱ⺸�� �������� �Ŵ����� �л���� ���������?
    /*[SerializeField] int fireCount;

    public void AddFireCount()
    {
        fireCount++;
    }*/
}
