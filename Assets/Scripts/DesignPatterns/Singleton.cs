using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 디자인 패턴 싱글톤(Singleton)

// <싱글톤 패턴>
// 오직 한개의 클래스 인스턴스만을 갖도록 보장
// 이에 대한 전역적인 접근점을 제공

// 장점
// 1. 하나뿐인 존재로 주요 클래스, 관리자의 역할을 함
// 2. 전역적 접근으로 참조에 필요한 작업이 없이 빠른접근가능
// 3. 인스턴스들이 싱글톤을 통하여 데이터를 공유하기 쉬워짐

// 단점
// 1. 싱글톤이 너무 많은 책임을 짊어지는 경우 주의해야함
// 2. 싱글톤의 남발로 전역접근이 많아지게 되는 경우, 참조하는 코드들의 결합도가 높아진다.
// 3. 싱글톤의 데이터를 공유할 경우 데이터 변조에 주의해야함(단점은 아니고 주의가 필요)




// 싱글톤 구현
//  1. 생성자의 접근권한을 외부에서 생성할 수 없도록 제한
//	2. 정적변수를 활용하여 캡슐화를 진행
//	3. 전역에서 접근 가능한 인스턴스를 갖기 위해 정적변수를 사용
//	4. GetInstance 함수를 통해서 단일개체가 없는 경우 생성
//	5. 단일객체가 있는 경우는 단일객체를 반환해 주도록 구현

public class Singleton
{
    private static Singleton instance;
    private Singleton() { }
    public static Singleton GetInstance()
    {
        if (instance == null) // 인스턴스가 없을 때
        {
            instance = new Singleton(); // 클래스 안에서 만들어줌
        }
        return instance; // 그걸 반환해줌 (한번 생성되면 2번째부터는 같은걸로 감)
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
        이렇게는 못씀
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
