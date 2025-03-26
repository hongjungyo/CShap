using Inheritance04;
using UnityEngine;
namespace Override
{
    //Metho Override (메서드 재정의, 메서드 오버라이드)
    //부모클래스의 메서드로 재정의(다시 정의)해서 사용하기
    public class OverrideDescription : MonoBehaviour
    {
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Child child = new Child();
            child.Say();
            child.Run();
            child.Walk();


            
        }
    }
}