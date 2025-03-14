using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// 제네릭 리스트: 배열, 제네릭 리스트와 비교
public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 배열 - 정수형 배열 변수 선언하고 요소수 생성 
        int[] arrNumbers = new int[2];

        //[2] 초기화
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;

        //[3] 배열 사용
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);
        }

        //제네릭 리스트 : List<T>
        //[1]Int형 전용의 List 인스턴스 생성
        List<int> listNumbers = new List<int>();

        //[2] 리스트에 데이터 넣기
        listNumbers.Add(30);
        listNumbers.Add(40);

        for (int i = 0; i < listNumbers.Count; i++)
        {
            Debug.Log(listNumbers[i]);
        }

        listNumbers.Add(50);

        for (int i = 0; i < listNumbers.Count; i++)
        {
            Debug.Log(listNumbers[i]);
        }
    }
}
