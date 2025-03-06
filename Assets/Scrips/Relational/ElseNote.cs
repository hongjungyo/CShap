using UnityEngine;

//만약 score가 60점 이상이면 "합격" 이라고 출력,
//만약 score가 60점 이상이 아니면 "불합격" 이라고 출력,
//스코어는 61점
public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(1 !=1 )
        {
            //실행문 1
             //Debug.Log("조건식이 참이면 실행문 1을 실행 합니다.");
        }
        else
        {
            //실행문 2
            Debug.Log("조건식이 거짓이면 실행문 2를 실행 합니다.");

        }
        //실행문 3
    }
}

/*
 else 문 
만약 조건식이 참이면 실행문 1을 실행하고  \실행문 2는  실행하지 않는다. 
조건식이 거짓이면 실행문 2를 실행하고  실행문 1은  실행하지 않는다. 

If(조건식)
{
    //실행문 1
}
else
{
    //실행문 2
}
    //실행문 3

1. 조건식이 참이면 
실행문 1 -> 실행문 3


2. 조건식이 거짓이면  
실행문 2 -> 실행문 3 

*/