using UnityEngine;

namespace Method
{
    //[1] 값 전달 방법     (int num)
    public class ParameterIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int num = 10;
            Debug.Log($"[1]: {num}"); //[1] 10
            PrintNumber(num);

            Debug.Log($"[3]: {num}"); // [3] 10
        }
        //매개변수로 전달 받은 정수(int)를 출력하는 함수
        void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"{num}");    //[2] 20
        }
    }
}
/*
[1] 10
[2] 20
[3] 10
*/
/*
매개변수 ( ) - 값이 전달되는 방법을 구분
[1] 값 전달 방법     (int num)
[2] 참조 전달 방법   (ref num)
[3] 반환형 전달 방법 (out int num)
[4] 가변형 전달 방법 (params int[] numbers)



*/