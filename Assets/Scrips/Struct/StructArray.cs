using Unity.VisualScripting;
using UnityEngine;

//[1] 구조체 정의, 선언 : 고객의 데이터를 관리하는 구조체 만들기

struct UserInfo
{
    public string name; //고객이름
    public int age;     //고객 나이
    //......
}

public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UserInfo Info;
        Info.name = "홍길동";
        Info.age = 20;

        PrintUserInfo(Info.name, Info.age);

        int n;
        n = 2;
        //[1]구조체의 배열 변수 선언, 요소수(크기) 생성
        UserInfo[] userInfos = new UserInfo[n];
        //[2] 구조체 배열 초기화
        userInfos[0].name = "백두산";
        userInfos[0].age = 22;

        userInfos[1].name = "임꺽정";
        userInfos[1].age = 33;
        
        for(int i =0; i < userInfos.Length; i++)
        {
            //PrintUserInfo(userInfos[i].name, userInfos[i].age);
            
        }


    }

    //고객 명단을 출력하는 함수
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}님의 나이는 {age}살 입니다.");
    }

}
