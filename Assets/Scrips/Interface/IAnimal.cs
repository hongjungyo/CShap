using UnityEngine;
namespace Interface
{
    public interface IAnimal
    {
        void Eat();
    }
    public interface IDog
    {
        void cry();
    }
    //[2] IAnimal 인터페이스 상속
    public class Cat 
    {
        
    }

    //다른 클래스 상속과 함께 인터페이스의 다중 상속 가능
    public class MyCat : Cat, IAnimal
    {
        public void Eat() { }
    }

    public class Dog : IAnimal, IDog
    {
        public void Eat() { }
        public void cry() { }
    }
}