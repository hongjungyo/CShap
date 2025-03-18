using UnityEngine;
namespace PrivatePublic
{
    public class Car
    {
        //필드(전역변수, 멤버 변수) - public, private
        public string Name; //이름
        private int age;    //나이
        string address;     //접근제한자가 생략되면 기본값인 private으로 설정

        //멤버 메서드 - public, private

        public void Hi()
        {
            Debug.Log("안녕하세요");
        }

        private void Bye()
        {
            Debug.Log("안녕히 계세요");
        }

        //private한 필드를 외부에 공개하고자할 때 public한 메서드를 이용한다
        //매개변수로 나이를 입력받아 age에 저장하는 함수
        public void SetAge(int nai)
        {
            age = nai;
        }
        //age를 반환하는 함수
        public int GetAge()
        {
            return age;
        }

    }
}