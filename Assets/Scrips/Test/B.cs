using UnityEngine;
//클래스(B) 만들기
public class B : MonoBehaviour
{

    //클래스(A)의 인스턴스 함수를 호출하기 -(스태틱이기 때문에 자동호출)
    
    void Start()
    {
        A a = new A();
        a.PrintWeekdays();
        //클래스(A)의 정적 함수를 호출하여 결과값을 반환 받아 출력하기 : 매개변수(5, 6)
        Debug.Log(A.number(5, 6));
    }
}

