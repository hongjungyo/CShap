using UnityEngine;

//1부터 20까지의 합을 구하는 프로그램 구현
public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 n(20)까지의 합을 구하는 프로그램 구현
        //1+2+3+4+5+......+19 +20
        int n = 20;
        int sum =0;

        for (int i = 0; i < n+1; i++ ) 
        {
            sum = sum + 1;
        }

        Debug.Log($"합은 {sum}");
    }
}
