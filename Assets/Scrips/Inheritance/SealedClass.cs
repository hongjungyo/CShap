using UnityEngine;
namespace Inheritance07
{
    public class SealedClass : MonoBehaviour
    {
        //Sealed(봉인) 클래스 : 최종 클래스, 더 이상 상속되지 못합니다.
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Cat 클래스의 인스턴스 생성
            Cat cat = new Cat();
            cat.Eat();
        }
    }
}