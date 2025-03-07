using UnityEngine;

public class WhileSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        //[1] 초기식

        int i = 1;

        while (i <= n) //[2]조건식
        {
            //반복실행문
            if(i % 2 == 0)       //짝수 판별식
            {
                sum += i;
            }

            //[3]증감식
            i++;
        }
        Debug.Log($"1부터 {n} 까지의 짝수의 합: {sum}");

    }
}
