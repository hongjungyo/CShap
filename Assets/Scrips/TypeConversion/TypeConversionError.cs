using UnityEngine;

//TypeConversion(형식변환)
public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Long형 변수 L 을 선언하고 Long 형 변수가 가질 수 있는 가장 큰 값을 저장합니다.
        long l = long.MaxValue;
        Debug.Log("l의 값:"+l); //L 값을 콘솔창에 출력하라
        //int형 변수 i를 선언하고 l값을 저장한다.
        int i = (int)l;
        Debug.Log("i의 값:" + i);

    }
}
