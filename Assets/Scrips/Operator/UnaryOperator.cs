using UnityEngine;

//UnaryOperator(단항연산자): +, -
public class UnaryOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 value 선언하고 0으로 초기화
        int value = 0;
        
        //[1]
        value = 8;         //value변수에 값 8을 저장
        value = +value;
        Debug.Log(value); // => 8

        //[2]
        value = -8;
        value = +value;
        Debug.Log(value); // => -8

        //[3]
        value = 8;         //value변수에 값 8을 저장
        value = -value;
        Debug.Log(value); // => -8

        //[4]
        value = -8;
        value = -value;
        Debug.Log(value); // => 8
    }
}
