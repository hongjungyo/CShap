using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string result = "Ȧ��";
        int num = 3;

        Debug.Log($"{num}��(��) {result} �Դϴ�.");

    }
}


/*

[Q]

3, Ȧ���� ���� �����ϰ� �����մϴ�. 

���ڿ� �������� �̿��ؼ� ����� ������ ��� 

[out put]

3��(��) Ȧ�� �Դϴ�.


*/