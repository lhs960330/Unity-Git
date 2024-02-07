using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public void GamePause()
    {
        Time.timeScale = 0;
    } 

    public void GameResume()
    {
        Time.timeScale = 1;
    }
   
}
