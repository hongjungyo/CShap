using UnityEngine;
namespace Inheritance04
{
    public class InheritanceClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ParentClass 인스턴스 생성
            ParentClass parent = new ParentClass();
            //parent.PrintMessage();

            //ChildClass 인스턴스 생성
            ChildClass child = new ChildClass();
            child.PrintMessage2();

            //SubClass 인스턴스 생성
            SubClass sub = new SubClass();

            sub.PrintDebug();
        }
    }
}
/*
접근 제한자: public, private, protected
protected :  상속받은 자식 클래스 {} 코드 블록 안에서만 접근 가능, 사용가능

public : 외부 클래스에서 접근, 사용 가능
private: 외부 클래스에서 접근, 사용 불가능
protected: private과 동일, 단 상속받은 자식 클래스의 코드 블록 안에서는 사용 가능



*/