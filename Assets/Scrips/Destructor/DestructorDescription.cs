using System;
using UnityEngine;
namespace Constructor
{
    public class DestructorDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            DestructorTest destructorTest = new DestructorTest();

            //인스턴스 객체 사용
            destructorTest.Run();

            //GC.Collect - DestructorTest 클래스 소멸자 호출
            //~DestructorTest();
        }
    }
}

/*
Destructor(소멸자)
: 클래스가 사용된 후 가장 마지막에 호출되는 메서드
: 생성된 인스턴스 (객체)가 메모리상에서 없어질때 호출되는 메서드
: 클래스에서 사용된 메모리 해제 등..

C#에서 메모리 해제 : GC(가비지 컬렉터)가 메모리 해제 역할을 대신해줌

Destructor(소멸자) 형식

class ClassName
{
    ~ClassName()
    {

    }

}

*/