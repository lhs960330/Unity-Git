using System.Collections.Generic;
// 디자인 패턴 옵저버

/* <옵저버 패턴>
 * 
 * 옵저버는 객체의 상태 변화를 관찰하는 관찰자
 * 관찰대상객체는 옵저버들의 목록을 등록하여 보관
 * 관찰대상객체에 상태 변화가 있을 때마다 등록한 옵저버들에게 알림
 */
// 구현:
// 0. C#의 경우 event delegate를 이용하여 옵저버 패턴을 적용가능
// 0. 유니티의 경우 UnityEvent를 이용하여 옵저버 패턴을 적용가능

// 옵저버나 이벤트 델리게이트나 똑같다.

// 장점
// 1. 클래스간의 느슨한 연결구조로 유연한 객체지향 시스템을 구축
// 2. 개방폐쇄원칙을 준수하게 됨
// 3. 프레임마다 상태 변화를 확인하는 방법보다 연산량이 줄일 수 있음

// 단점
// 1. 순서를 보장할 수 없음
// 2. 부주의한 사용은 이벤트 연쇄, 순환 구조등의 문제가 발생할 수 있음


public class Observer
{
    public void Notify() { }
}

public class Subject
{
    // 리스트 생성
    private List<Observer> observerList;

    public void RegisterObserver(Observer observer)
    {
        // 추가
        observerList.Add(observer);
    }

    public void UnregisterObserver(Observer observer)
    {
        // 삭제
        observerList.Remove(observer);
    }
    // 사건이 실행되면
    private void NotifyObserver()
    {
        // 꺼내서 실행
        foreach (Observer observer in observerList)
        {
            observer.Notify();
        }
    }
}
