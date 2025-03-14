using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class LinqCount2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool형 배열 변수에서 true값의 갯수, false 값의 개수 구하기
        bool[] bins = { true, false, true, false, true };

        //전체 요소수

        Debug.Log(bins.Count());

        //true 값의 갯수
        Debug.Log(bins.Count(b => b == true));  //3
        
        //false 값의 갯수
        Debug.Log(bins.Count(b => b == false));  //2

    }
}
