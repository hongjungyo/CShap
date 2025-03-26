using UnityEngine;
//Generic Class(제네릭 클래스)
//: 형식 매개 변수 T에 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
//Cup<T> : 컵오브티, 전용 컵
namespace GenericClass
{
    public class Water { }

    public class Coffee { }

    //제네릭 클래스 만들기 - 클래스 이름<T>
    public class Cup<T>
    {
        public T Content { get; set; }
    }
}