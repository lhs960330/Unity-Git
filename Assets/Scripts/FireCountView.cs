using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Scripting;

public class FireCountView : MonoBehaviour
{
    public TMP_Text text;


    private void OnEnable()
    {
        UpdateView(Manager.Data.FireCount);
        Manager.Data.OnFireCountChanged += UpdateView;
    }



   /* private void OnDisable()
    {
        Manager.Data.OnFireCountChanged -= UpdateView;
    }*/
   

    private void UpdateView(int value)
    {
        text.text = value.ToString();
    }
}
