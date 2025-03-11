using UnityEngine;

//팩토리얼 구하는 알고리즘
public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(4 * 3 * 2 * 1);

        //For Factorial
        Debug.Log(FactorialFor(4));


    }

    int FactorialFor(int n)
    {
        int result = 1;
        for (int i = 0; i <= n; i++)
        {
            result *= i;
        }
        return (result);

    }
    
    
    //제귀함수 이용 Factorial 값 구하기
    int Factorial(int n)
    {
        //종료 조건 부분
        if(n==1)
        {
            return 1;
        }

            //재귀 호출 부분

        return n * Factorial(n - 1);
    }
    /*
            4 * Factorial(3);
                3 * Factorial(2);
                    2 * Factorial(1);
                        1 * Factorial(0);
                            0 * Factorial(-1);
                                
    

     */

}
/*
재귀함수 : 함수가 자신의 코드블록 한에서 자기자신을 다시 호출(재귀호출)하는 함수
- 재귀함수 배개변수 : 매개변수는 감산 가산이 된다.
-재귀함수 코드 블록 안에는 재귀함수를 종료 할 수 있는 조건이 필요하다.

*/
