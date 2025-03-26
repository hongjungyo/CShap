using UnityEngine;
namespace Inheritance10
{
    //원을 관리하는 클래스
    public class Circle : Shape
    {
        //필드
        private int size; // 반지름의 길이

        //생성자
        public Circle(int _size)
        {
            this.size = _size;
        }

        //부모 클래스의 추산 메서드 (GetArea)()를 구현
        public override double GetArea()
        {
            return size * size * 3.14;
        }
    }
}