using UnityEngine;

public class IfElseIfElse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] number1 크면 number1이 큽니다 출력
        //[2] number2 크면 number2가 큽니다 출력
        //[3] 나머지는 두수의 크기가 같습니다.

        //선언문
        int number1 = 10;
        int number2 = 10;

       
    if(number1 > number2)  //조건식1
        {
            //실행문 1
            Debug.Log("number1이 큽니다");
        }
        else if(number1 < number2)  //조건식 2
        {
            //실행문 2
            Debug.Log("number2가 큽니다");
        }
        else
        {   //실행문 3
            Debug.Log("나머지는 두수의 크기가 같습니다.");
        }
            //실행문 4
    }
}

/*
    [1] 조건식1 참이면
    선언문 -> 실행문1 -> 실행문 4

   [2] 조건식 1 거짓이고 조건식 2가 참이면
    선언문 -> 실행문 2 -> 실행문 4

   [3] 조건식 1,2 거짓이고 조건식 3가 참이면
    선언문 -> 실행문 3 -> 실행문 4

    [4] 조건식 1 참이고 조건식 2 참이면
        선언문 -> 실행문1 -> 실행문 4

    


*/