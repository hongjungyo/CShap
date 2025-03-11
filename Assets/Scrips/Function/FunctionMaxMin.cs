using Unity.Mathematics;
using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3, 5를 입력 받아 큰수 출력하기
        int max = GetMax(3, 5);
        Debug.Log($"3과 5중 큰 수는{max}이다");

    }
    //[1] 매개변수로 입력받은 두개의 정수중 큰 수를 반환하는 함수


    int GetMax(int x, int y)
    {
        /*
        int Maxvalue;
            if(x > y)
        {
            Maxvalue = x;
        }
        else
        {
            Maxvalue = y;

        }
        return Maxvalue;
        */


        //3항 연산자
        //int maxValue = (x > y) ?  x : y;
        //return maxValue;

        if (x > y)
        {
            return x;

        }
        else
        {
            return y;  
        }
    }
}

/*
[Q]

1. 매개변수를 입력받은 두개의 정수중 큰수를 반환하는 변수
2. 매개변수를 입력받은 두개의 정수중 작은 수를 반환하는 변수
3. 3, 5를 입력 받아 큰수 출력하기
4. -3, -5를 입력 받아 작은수 출력하기

[output]
3과 5중 큰수는 (반환값) 이다
-3과 -5중 작은 수는 (반환값) 이다


*/
