using UnityEngine;

namespace Method
{
    public class Ractangleclass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //클래스의 인스턴스 생성
            Ractangle ractangle = new Ractangle();
            Debug.Log( ractangle.GetName());
        }
    }
}

/*
[1] 메서드 구성
public(private) static(x) void(반환 타입 없다, int, string) 메서드 이름 (매개변수..)
{
    //메서드 실행문

}
[2] 메서드 이름 - 스타일
동사 + 이름 :
()를 가져온다 -> GetName(), GetHP()
()를 저장한다 -> SetName("홍길동");



*/