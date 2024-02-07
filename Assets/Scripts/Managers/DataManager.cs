using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] int fireCount;
    //UnityAction == C# 델리게이트 액션이라 생각하면됨
    public UnityAction<int> OnFireCountChanged;
    public int FireCount { set { fireCount = value; OnFireCountChanged?.Invoke(value); } get { return fireCount; } }

   /* 위에와 같다.
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
