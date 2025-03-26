using PrivatePublic;
using UnityEngine;
namespace Delegate
{
    public class DelegateNote : MonoBehaviour
    {
        //집에 가기 : 직진 -> 우회전 -> 직진 5 -> 좌회전

        //대리자 선언 - 반환값도 없고 매개변수도 없다
        delegate void Gohome();

        //Delegate 변수 선언하고 메서드 등록
        Gohome go;

        // Action 형식을 통해 대리자 객체 생성
        // Action, Func
        System.Action driver;

        //대리자 선언
        delegate void Say();
        //Delegate 변수 선언
        Say say3;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //직접 운전 : 직진 -> 우회전 -> 직진 5 -> 좌회전
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoForward();
            CarDriver.GoLeft();

            Debug.Log("===============");

            //대리자 변수에 메서드 등록
            go = new Gohome(CarDriver.GoForward);
            go += new Gohome(CarDriver.GoRight);
            go += new Gohome(CarDriver.GoForward);
            go += new Gohome(CarDriver.GoLeft);
            go += new Gohome(CarDriver.GoForward); //등록
            go -= new Gohome(CarDriver.GoForward); //등록 취소
            
            Debug.Log("===============");


            go();
            //대리자 변수 선언 및 메서드 등록
            Say say = new Say(Hello);
            say += new Say(Hi);
            say.Invoke();


            Insa insa = new Insa();
            //대리자 변수 선언 및 메서드 등록
            Say say2 = insa.Bye;
            say2 += insa.Bye;
            say2 += Hi;
            say2.Invoke();
            Debug.Log("===============");

            //매서드 등록 없이 호출: say3 = null
            /*if (say3 != null)
            {
                say3.Invoke();
            }
            */
            say3?.Invoke();

            driver = CarDriver.GoForward;
            driver += CarDriver.GoRight;
            driver += () => Debug.Log("후진");
            driver += delegate () { Debug.Log("주차"); };
            driver.Invoke();
        }
        void Hello() => Debug.Log("Hello");

        void Hi()
        {
            Debug.Log("Hi");
        }
    }
}