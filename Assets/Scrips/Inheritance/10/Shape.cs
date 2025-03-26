using UnityEngine;
namespace Inheritance10
{
    //추상 클래스
    //추상 메서드 기능 : 도형의 면적을 구하는 메서드를 구현하도록 지정
    public abstract class Shape
    {
        public abstract double GetArea();
    }
}