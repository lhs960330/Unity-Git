using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ������ ���� �̱���(Singleton)

// <�̱��� ����>
// ���� �Ѱ��� Ŭ���� �ν��Ͻ����� ������ ����
// �̿� ���� �������� �������� ����

// ����
// 1. �ϳ����� ����� �ֿ� Ŭ����, �������� ������ ��
// 2. ������ �������� ������ �ʿ��� �۾��� ���� �������ٰ���
// 3. �ν��Ͻ����� �̱����� ���Ͽ� �����͸� �����ϱ� ������

// ����
// 1. �̱����� �ʹ� ���� å���� �������� ��� �����ؾ���
// 2. �̱����� ���߷� ���������� �������� �Ǵ� ���, �����ϴ� �ڵ���� ���յ��� ��������.
// 3. �̱����� �����͸� ������ ��� ������ ������ �����ؾ���(������ �ƴϰ� ���ǰ� �ʿ�)




// �̱��� ����
//  1. �������� ���ٱ����� �ܺο��� ������ �� ������ ����
//	2. ���������� Ȱ���Ͽ� ĸ��ȭ�� ����
//	3. �������� ���� ������ �ν��Ͻ��� ���� ���� ���������� ���
//	4. GetInstance �Լ��� ���ؼ� ���ϰ�ü�� ���� ��� ����
//	5. ���ϰ�ü�� �ִ� ���� ���ϰ�ü�� ��ȯ�� �ֵ��� ����

public class Singleton
{
    private static Singleton instance;
    private Singleton() { }
    public static Singleton GetInstance()
    {
        if (instance == null) // �ν��Ͻ��� ���� ��
        {
            instance = new Singleton(); // Ŭ���� �ȿ��� �������
        }
        return instance; // �װ� ��ȯ���� (�ѹ� �����Ǹ� 2��°���ʹ� �����ɷ� ��)
    }
    public int gold = 0;

}
public class Player
{
    public void SpendGold()
    {
        Singleton.GetInstance().gold -= 100;
        /*Singleton a = Singleton.GetInstance();
        Singleton b = Singleton.GetInstance();
        Singleton c = Singleton.GetInstance();*/
        /*
        �̷��Դ� ����
        Singleton instance1 = new Singleton();
        Singleton instance2 = new Singleton();
        */
    }
}
public class Item1
{
    public void GetGold()
    {
        Singleton.GetInstance().gold += 100;
    }
}
public class Monster
{
    public void Die()
    {
        Singleton.GetInstance().gold += 100;
        //Inventory singleton = Inventory.GetInstance();
    }
}
