using UnityEngine;

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();
        Hi("반갑습니다");
        Hi("감사합니다", 3);
    }

    //인사하는 함수 구현하기 : Hi
    //매개변수가 없는 함수
    void Hi()
        {
        Debug.Log("안녕하세요");
        }

    //매개변수(Message)가 있는 함수
    void Hi(string Message)
    {
        Debug.Log(Message);
    }

    //매개변수로 입력받은 (Message)를  받은 (count)횟수 만큼 인사

    void Hi(string Message, int count)
    {
        for(int i =0; i< count; i++)
        {
            Debug.Log("안녕하세요");

        }
    }



}
