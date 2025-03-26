using UnityEngine;
namespace InterfaceTest
{
    public class CarWorld : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] car 클래스 인스턴스 생성
            Car car = new Car("캠핑카");
            car.Run();
            //[2] 속성
            Car car1 = new Car();
            car1.Name = "스포츠카";
            car1.Run();
            //[3] 인덱서
            Car car3 = new Car(2);
            car3[0] = "1번 자동차";
            car3[1] = "2번 자동차";

            foreach (var c in car3)
            {
                Debug.Log(c);
            }

        }
    }
}

/*
객체지향 프로그래밍
- 추상화
- 캡슐화
- 상속
- 다형성



*/