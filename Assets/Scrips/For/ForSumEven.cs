using Unity.VisualScripting;
using UnityEngine;

public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 2+4+6+8+10

        int n =10;
        int sum = 0;


        for (int i = 0; i <= n; i = i + 2)
        {
            sum = sum + i;
        }
        Debug.Log($"2+4+6+8+10={sum}");
    }
}
