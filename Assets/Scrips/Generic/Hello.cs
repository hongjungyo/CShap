using UnityEngine;
namespace GenericClass
{
    //제네릭 클래스 만들기 - 설계
    public class Hello<T>
    {
        //필드 
        private T _message;

        public Hello()
        {
            _message = default(T);
        }

        public Hello(T message)
        {
            _message = message;
        }

        //메서드
        public void Say(T message)
        {
            Debug.Log($"message");
        }
        public T Getmassage() => this._message;

    }
}