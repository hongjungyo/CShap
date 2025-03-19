using UnityEngine;
namespace Method
{
    public class ParameterOut : MonoBehaviour
    {
       //[3] 반환형 전달 방법(out int num)

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //정수형 변수 선언 초기화 x
            int number;
            //Debug.Log($"[1]: {number}"); //[1] 10
            PrintNumber(out number);

            Debug.Log($"[3]: {number}"); // [3] 1234
        }

        //정수형 out number를 매개 변수로 입력받아 출력하는 함수
        //반환형 배개 변수 전달 방식
        //참조형 방식과 동일, 함수 내부에서 반드시 초기화(값)을 설정

        void PrintNumber(out int number)
         {
            number = 1234;
            Debug.Log($"[2]:{number}"); //[2] 1234
         }
    }
}