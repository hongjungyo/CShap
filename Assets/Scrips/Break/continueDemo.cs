using UnityEngine;

//1���� 100������ �����߿��� 3�� ����� ������ ���� ���ϴ� ���α׷� ����
public class continueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        for (int i =1; i <= n; i++) //[2]���ǽ�
        {
            //�ݺ����๮
            if (i % 3 == 0)       //3�� ��� �Ǻ���
            {
                continue;
            }

            sum += i;

        }
        Debug.Log($"1���� 100������ �����߿��� 3�� ����� ������ ��:{sum}");
    }
}
