using UnityEngine;
using System.Linq;

//Sum : 모든 요소들의 합, 
public class LinqSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 배열 선언및 초기화
        int[] numbers = { 1, 2, 3 };
        int sum = 0;

        sum = numbers.Sum();
        Debug.Log($"numbers요소들의 합: {sum}");



    }
}
