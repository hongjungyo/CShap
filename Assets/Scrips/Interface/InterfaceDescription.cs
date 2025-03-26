using UnityEngine;
namespace Interface
{
    public class InterfaceDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
         void Start()
         {
            //Icar 인터페이스 인스턴스 생성
            //ICar icar = new ICar();

            //Icar 인터페이스에 상속받은 Car클래스의 인스턴스 생성
            Car car = new Car();
            car.Go();
         }
    }
}
/*
Interface (인터페이스)
: 상속받은 자식 클래스가 특정 멤버를 반드시 구현되어야 함을 보증
: 상속받은 자식 클래스가 특정 멤버를 구현하도록 강제한다.
: 인터페이스 이름 작명시 맨 앞에 있는 문자는 대문자 I를 붙인다.

Interface (인터페이스) 형식
public intrface (인터페이스 이름)
{
    메서드 이름(); //메서드 선언 - 구현부분 생략
    //......
}



*/