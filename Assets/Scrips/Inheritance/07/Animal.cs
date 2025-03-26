using UnityEngine;
namespace Inheritance07
{
    public class Animal
    {
        public void Eat() => Debug.Log("밥을 먹어요");
    }


    //자식 클래스 Animal을 부모로 지정
    //sealed : Cat 클래스를 봉인(sealed) 클래스로 지정, 최종 클래스가 되어 상속이 불가하다
    public class Cat : Animal
    {

    }
    //자식 클래스 : Cat을 부모로 지정
    /*public class MyCat : Cat
    {
       // sealed 가 붙은 클래스는 부모로 지정이 불가능
    }*/
}