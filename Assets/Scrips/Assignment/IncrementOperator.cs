using UnityEngine;

//IncrementOperator(증가 연산자): 정수의 변수의 값을 1증가
public class IncrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 100;

        //1 증가식 
        //num = num + 1;
        //num += 1;
        ++num;      //101

        Debug.Log("num:" + num );



    }
}
