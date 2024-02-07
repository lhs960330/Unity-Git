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
            Destroy(this); //이미 있으면 지워주는 방식으로 사용하자
            return;
        }
        instance = this; // 새로운 친구를 this로 지정

        DontDestroyOnLoad(this);  // 다른 씬에 가서 쓸수 있게 만들어주는 함수
    }

    private void OnDestroy()
    {
        // 인스턴스가 사라지면 null바꿔준다.
        if (instance == this)
        {
            instance = null;
        }
    }

    // 싱글톤을 이용한 기능 구현
    // 탱크가 쏜 탄환의 총 갯수를 구현했다.
    // 매니저 자체에 구현하기보단 여러개의 매니저에 분산시켜 만들면좋다?
    /*[SerializeField] int fireCount;

    public void AddFireCount()
    {
        fireCount++;
    }*/
}
