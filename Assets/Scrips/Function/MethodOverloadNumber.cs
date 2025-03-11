using UnityEngine;

//MethodOverload(메서드 오버로드, 함수 다중 정의)
//동일한 이름의 메서드를 매개변수를 달리해서 여러개 생성하는 것 
public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        printNumber(1234);
        printNumber(1234L);
        printNumber(1234F);


    }

    //매개변수로 숫자를 입력받아 출력하는 함수 : PrintNumber
    //int 타입의 정수를 매개변수로 입력받아 출력
    void printNumber(int number)
    {
        Debug.Log($"Int32: {number}");
    }
    
    //long 타입의 정수를 매개변수로 입력받아 출력
    void printNumber(long number)
    {
        Debug.Log($"Int32: {number}");
    }

    //float 타입의 정수를 매개변수로 입력받아 출력
    void printNumber(float number)
    {
        Debug.Log($"Int32: {number}");
    }
}
