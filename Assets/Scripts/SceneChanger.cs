using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
