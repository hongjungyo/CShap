using System.Linq;
using UnityEngine;

public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { -2, -5, -3, -7, -1 };

        int max = 0;

        max = numbers.Max();

        Debug.Log($"최댓값:{max}");


    }
}

/*[Q]
입력 데이터 {-2, -5, -3, -7, -1}
입력 데이터 중에서 최댓값을 구하시오

[out put]
최댓값: -1
*/