using UnityEngine;

namespace Method
{
    //[2] 참조 전달 방법(ref num)

    public class ParameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log($"[1]: {number}"); //[1] 10
            Printnumber(ref number);

            Debug.Log($"[3]: {number}"); // [3] 20
        }
        //정수형 ref number를 매개변수로 입력받아 출력하는 함수
        void Printnumber(ref int number)
        {
            number = 20;
            Debug.Log($"[1]:{number}"); //[2] 20
        }
    }
}