using Override;
using UnityEngine;
namespace Override
{
    public enum CarType
    {
        전기,
        내연기관
    }

    //부모 클래스 - 추상 클래스(인스턴스 생성 불가)
    public abstract class CarBase
    {
        public abstract void Left();  //추상 메서드, 본문(구현내용) 없음

        //접근 제한자 public - 자식 클래스와 외부 모든 클래스에서 접근, 사용가능
        public void Back() => Debug.Log("후진");

        //접근제한자 protected -자식클래스에서만 접근, 사용가능
        //접근제한자 private - 외부의 모든 클래스에서 접근 불가
        //                    -private을 선언한 클래스 코드 블록 안에서만 사용가능
        protected string LeftMessage { get; set; } = " 좌회전한다";
    }
    //자식 클래스

    public class Car : CarBase
    {
        //모든 자동차에 공통 속성
        public CarType Style { get; private set; }

        //생성자 - 매개변수를 입력받아 CarType 초기화
        public Car(CarType cType)
        {
            //this 키워드를 자신의 멤버에 접근
            this.Style = cType;
        }

        public void Go() => Debug.Log("달린다");

        //부모의 추상 메서드를 실제 코드 구현, 재정의
        public override void Left()
        {
            //base 키워드를 부모멤버에 접근(public, protected)
            Debug.Log(LeftMessage);
        }
    }
    public class HyunDai : Car
    {
            public HyunDai() : this(CarType.내연기관) { }




            public HyunDai(CarType carType) : base(carType) { }
    }
        public class Tesla : Car
        {
        public Tesla() : this(CarType.전기) { }
        public Tesla(CarType carType) : base(carType) { }
        }
        public class Mirae : Car
        {
        public Mirae() : this(CarType.전기) { }
        public Mirae(CarType carType) : base(carType) { }
        public new void Go() => Debug.Log("난다");

        //public class Future : Mirae { }
        }
}