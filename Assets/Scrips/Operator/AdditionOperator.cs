using UnityEngine;

// +: 더하기 연산의 추가 기능
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + "World!!!"); //문자열 더하기   
        Debug.Log("Hi" + " " + "Everyone");
        
        Debug.Log("123" + "456");    //문자열 + 문자열 => 문자열
        Debug.Log("123" + 456);     // 문자열 + 숫자열 => 문자열
        
        Debug.Log(123 + "456" + 789 +890); // 숫자열 + 문자열 => 문자열
        Debug.Log(123 + 456);               // 숫자열 + 숫자열 => 숫자열

        Debug.Log("123" + true);            //문자형 +bool형 => 문자열

        //Debug.Log()"123" -456);             //문자열에서 정수형 데이터 빼기 없음
    }
}
