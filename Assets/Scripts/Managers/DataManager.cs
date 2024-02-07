using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] int fireCount;
    //UnityAction == C# ��������Ʈ �׼��̶� �����ϸ��
    public UnityAction<int> OnFireCountChanged;
    public int FireCount { set { fireCount = value; OnFireCountChanged?.Invoke(value); } get { return fireCount; } }

   /* ������ ����.
    public void FireCount(int value)
    {
        fireCount = value;
        OnFireCountChanged?.Invoke(value);
    }
    public int FireCount()
    {
        return fireCount;
    }
   */
}
