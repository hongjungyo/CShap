using UnityEngine;
namespace Interface
{
        //[1] Icar 인터페이스 선언
        public interface ICar
        {
            void Go();      //메서드 정의, {} 구현부분 생략
        }
        //[2] Icar 인터페이스 상속
        public class Car : ICar
        {
            public void Go()
            {
            Debug.Log("상속한 인터페이스의 정의된 모든 멤버를 반드시 구현해야한다.");

            }
        }
}