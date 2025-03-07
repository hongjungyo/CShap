using Unity.VisualScripting;
using UnityEngine;

public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        int i = 1;
        int n = 100;
        do
        {
            if (i % 2 == 0)       //짝수 판별식
            {
                sum += i;
            }

            //[3]증감식
            i++;
        } while (i <= n);
        Debug.Log($"1부터 {n} 까지의 짝수의 합: {sum}");
    }
}
