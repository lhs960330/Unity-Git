using System.Collections.Generic;
// ������ ���� ������

/* <������ ����>
 * 
 * �������� ��ü�� ���� ��ȭ�� �����ϴ� ������
 * �������ü�� ���������� ����� ����Ͽ� ����
 * �������ü�� ���� ��ȭ�� ���� ������ ����� �������鿡�� �˸�
 */
// ����:
// 0. C#�� ��� event delegate�� �̿��Ͽ� ������ ������ ���밡��
// 0. ����Ƽ�� ��� UnityEvent�� �̿��Ͽ� ������ ������ ���밡��

// �������� �̺�Ʈ ��������Ʈ�� �Ȱ���.

// ����
// 1. Ŭ�������� ������ ���ᱸ���� ������ ��ü���� �ý����� ����
// 2. ��������Ģ�� �ؼ��ϰ� ��
// 3. �����Ӹ��� ���� ��ȭ�� Ȯ���ϴ� ������� ���귮�� ���� �� ����

// ����
// 1. ������ ������ �� ����
// 2. �������� ����� �̺�Ʈ ����, ��ȯ �������� ������ �߻��� �� ����


public class Observer
{
    public void Notify() { }
}

public class Subject
{
    // ����Ʈ ����
    private List<Observer> observerList;

    public void RegisterObserver(Observer observer)
    {
        // �߰�
        observerList.Add(observer);
    }

    public void UnregisterObserver(Observer observer)
    {
        // ����
        observerList.Remove(observer);
    }
    // ����� ����Ǹ�
    private void NotifyObserver()
    {
        // ������ ����
        foreach (Observer observer in observerList)
        {
            observer.Notify();
        }
    }
}
