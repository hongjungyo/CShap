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
            if (i % 2 == 0)       //¦�� �Ǻ���
            {
                sum += i;
            }

            //[3]������
            i++;
        } while (i <= n);
        Debug.Log($"1���� {n} ������ ¦���� ��: {sum}");
    }
}
