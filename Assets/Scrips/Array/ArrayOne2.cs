using UnityEngine;

public class ArrayOne2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1차원 배열 선언,  요소슈(갯수) 생성, 값 초기화를 동시
        //int[] intArray = new int[3] { 1, 2, 3 };
        //[1-2] 1차원 배열 선언,  요소슈(갯수) 생성 생략 , 값 초기화를 동시
        
        int[] intArray = { 1, 2, 3 };


        //[4]배열의 사용
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"i번째 방의 값은:{intArray[i]}");
        }

    }
}
