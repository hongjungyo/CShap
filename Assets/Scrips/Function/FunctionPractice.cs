using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((Add(5,3)));
        Debug.Log((Subtract(5, 3)));
        Debug.Log((Multiply(5, 3)));
        Debug.Log((Device(5, 3)));
        Debug.Log((Remainder(5, 3)));
        Hi("");
    }

    //화살표 함수, 람다식, 축약형 함수
    int Add(int x, int y) => x + y;
        /*
    {
        return x + y;
    }
        */

    int Subtract(int x, int y) => x - y;
    /*
{
    return x - y;
}
    */
    int Multiply(int x, int y) => x * y;

    /*
    {
        return x * y;
    }
    */

    int Device(int x, int y) => x / y;
    /*
    {
        return x / y;
    }
    */
    int Remainder(int x, int y) => x % y;
    /*
    {
        return x % y;
    }
    */

    void Hi(string msg) => Debug.Log("안녕하세요");
}

/*
[Q]
사칙연산을 구하는 함수 만들기

두개의 정수를 입력 받아 +, -, /, *, % 계산하여
결과값을 반환하는 함수 만들기
add, subtract, multiply, device, remainder

입력값: 5, 3
[output]





*/
