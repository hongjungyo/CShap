using UnityEngine;

//1���� 20������ ���� ���ϴ� ���α׷� ����
public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1���� n(20)������ ���� ���ϴ� ���α׷� ����
        //1+2+3+4+5+......+19 +20
        int n = 20;
        int sum =0;

        for (int i = 0; i < n+1; i++ ) 
        {
            sum = sum + 1;
        }

        Debug.Log($"���� {sum}");
    }
}
