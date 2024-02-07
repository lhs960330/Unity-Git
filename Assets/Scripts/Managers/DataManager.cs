using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] int fireCount;

    public void AddFireCount()
    {
        fireCount++;
    }
}
