using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//LinqWhere (Where절, 조건절)
public class LinqWhere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 배열 numbers의 요소수 3보다 크고 짝수인 수들 구하기
        int[] numbers = { 1, 2, 3, 4, 5 };

        //IEnumerable<int> numbers = numbers.Where(n => n >3);
        List<int> newnumbers = numbers.Where(n => n > 3 && n % 2 == 0).ToList();

        foreach (var n in newnumbers)
        {
            Debug.Log(n);
        }
    }
}
