using UnityEngine;

public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(int i = 0; i < 3; i++) 반복횟수: 3
        //for(int i = 1; i < 4; i++ )  반복횟수: 4 - 1
        //for(int i = 1; i <= 3; i++ ) 반복횟수: 3 - 1 + 1

        /*for (int i = 0; i < 3; i++)
        {
            //반복 실행문
            Debug.Log("안녕하세요");
        }
        */
        //[1] 초기식
        int i = 0;

        while(i < 3)
        {
            Debug.Log("안녕하세요");
            
            //증감식
            i++;
        }

        //int i =0 -> 조건식 판별(i:0) 참 -> 출력 -> 증감식 i:1 ->조건식 판별(i:1) 참 -> 출력 -> 증감식 i:2 ->
        //조건식 판별(i:2) 참->출력->증감식 i:3 ->조건식 판별(i:3) 거짓 -> 종료

    }
}
/*
While문 -> 반복문

조건식이 true이면 반복문을 실행한다.
조건식이 false이면 While문을 종료한다.

While(조건식)
{
    //반복 실행문
    
    //조건식에 들어가는 변수 증감식
}

조건식 판별(참) => 반복문 실행 => 조건식 판별(참) => 반복문 실행 => 


*/