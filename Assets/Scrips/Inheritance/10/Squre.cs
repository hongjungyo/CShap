using UnityEngine;
namespace Inheritance10
{
    //정사각형을관리하는 클래스
    //Shape(추상클래스)를 상속받는 자식 클래스
    public class Squre : Shape
    {
        //필드
        private int size; //한변의 길이

        //생성자
        public Squre(int _size)
        {
            this.size = _size;
        }

        //부모 클래스의 추산 메서드 (GetArea)()를 구현
        public override double GetArea()
        {
            return size * size;
        }
    }
}