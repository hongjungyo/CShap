using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 선언문

        int x = 2;

        //switch (조건) : 데이터의 값 판별
        switch(x)
        {
            case 1:
                Debug.Log("x는 1입니다."); //[1] 실행문1
                break;
            case 2:
                Debug.Log("x는 2입니다."); //[2] 실행문1
                break;
            case 3:
                Debug.Log("x는 3입니다."); //[3] 실행문1
                break;
        }
        //[4] 실행문
        Debug.Log("프로그램 종료");
    }
}
/*
 switch문 : 조건문 - 선택문 

switch(조건) : 데이터의 값 판별 
{
    case 1번:
        //실행문 1
        break:

    case 2번:
        //실행문 2
        break:

    case 3번:
        //실행문 3
        break:
   case 4번:
        //실행문 4
        break:

    default  //모든 case가 아니면
        //실행문 5
        break:
    
}

if(조건식) : 조건식 참 거짓 판별 
{
    실행문1
}
else
{
     실행문2
}


*/ 