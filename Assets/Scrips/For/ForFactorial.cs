using UnityEngine;

// 4!의 값을 구하는 프로그램 
public class ForFactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 4;
        int fact = 1;

        for (int i = 1; i < n + 1; i++)
        {
            Debug.Log($"fact: {fact} *{i}");
        }

        Debug.Log($"{n}! 값은{fact}");
    }
}
/*
Factorial(!)
1! = 1
2! = 1*2
3! = 1*2*3
4! = 1*2*3*4

......

n! = 1*2*3* ...... *(n-1)*n

*/