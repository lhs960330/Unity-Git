using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitiyFuniction : MonoBehaviour
{
    [Header("This")]
    public GameObject thisGameObject;
    public string thisName;
    public bool thisActive;
    public string thisTag;
    public int thisLayer;

    [Header("GameObject")]
    public GameObject newGameObject;
    public GameObject destroyGameObject;
    public GameObject findWithName;
    public GameObject findWithTag;

    [Header("Component")]
    // public Component newComponent;
    public Component addComponent;
    public Component destroyComponent;
    public Component getComponent;
    public Component findComponent;
    private void ThisFunction()
    {
        // <현재 게임오브젝트 참조>
        // 컴포넌트가 붙어있는 게임오브젝트는 Component에 구현한 gameObject 속성을 이용하여 접근가능
        thisGameObject = gameObject;         // 컴포넌트가 붙어있는 게임오브젝트
        thisName = gameObject.name;          // 게임오브젝트의 이름
        thisActive = gameObject.activeSelf;  // 게임오브젝트의 활성화 여부 (activeInHierarchy : 게임씬에서 활성화)
        thisTag = gameObject.tag;            // 게임오브젝트의 태그
        thisLayer = gameObject.layer;        // 게임오브젝트의 레이어
    }
    private void GmaeObjectFunction()
    {
        // 오브젝트 생성


        newGameObject = new GameObject("NewGameObject");

        // 오브젝트 제거
        if (destroyGameObject != null)
        {
            Destroy(destroyGameObject);
        }
        // 오브젝트 찾기
        findWithName = GameObject.Find("Main Camera");  // 이름가지고 찾기 (안씀)
        findWithTag = GameObject.FindWithTag("Player"); // 이름으로 찾는거 보다 빠르고 효과적으로 찾는다. 

    }
    private void ComponentFunction()
    {
        //컴포넌트 추가
        addComponent = gameObject.AddComponent<Rigidbody>();
        // newComponent = new Rigidbody();  // new해서 만들면 의미가 없음, 컴포넌트는 게임오브젝트에 부착되어 동작할때 의미가 있다.
        // 컴포넌트 삭제
        if (destroyComponent != null)
        {
            Destroy(destroyComponent);
        }
        // 컴포넌트 탐색 - 게임오브젝트에서 찾기 - 이 상황이 좀더 많이 나온다.
        getComponent = gameObject.GetComponent<Collider>();  // 인터페이스도 찾을 수 있다.

        // 컴포넌트 탐색 - 씬에서 찾기
        findComponent = Component.FindObjectOfType<Camera>();
        


    }
    private void Start()
    {
        ThisFunction();
        GmaeObjectFunction();
        ComponentFunction();
    }
}
