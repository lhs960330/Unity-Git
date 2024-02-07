using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] int fireCount;
    //UnityAction == C# ��������Ʈ �׼��̶� �����ϸ��
    public UnityAction<int> OnFireCountChanged;
   public int FireCount { set  { fireCount= value; OnFireCountChanged?.Invoke(value);  }get { return fireCount; } }
}
