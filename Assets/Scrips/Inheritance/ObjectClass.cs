using UnityEngine;
namespace Inheritance
{


    public class ObjectClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //static 메서드는 클래스의 인스턴스를 생성하지 않고 호출
            //static 메서드 호출방법: 클래스이름.메서드 이름
            ParentClass.Hi();
            ChildClass.Hello();

            //ParentClass 인스턴스 생성
            ParentClass parent = new ParentClass();
            Debug.Log(parent.ToString());
            
            //ChildClass 인스턴스 생성
            ChildClass child = new ChildClass();
            Debug.Log(child.ToString());

        }
    }
}