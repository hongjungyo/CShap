using Unity.Mathematics;
using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3, 5�� �Է� �޾� ū�� ����ϱ�
        int max = GetMax(3, 5);
        Debug.Log($"3�� 5�� ū ����{max}�̴�");

    }
    //[1] �Ű������� �Է¹��� �ΰ��� ������ ū ���� ��ȯ�ϴ� �Լ�


    int GetMax(int x, int y)
    {
        /*
        int Maxvalue;
            if(x > y)
        {
            Maxvalue = x;
        }
        else
        {
            Maxvalue = y;

        }
        return Maxvalue;
        */


        //3�� ������
        //int maxValue = (x > y) ?  x : y;
        //return maxValue;

        if (x > y)
        {
            return x;

        }
        else
        {
            return y;  
        }
    }
}

/*
[Q]

1. �Ű������� �Է¹��� �ΰ��� ������ ū���� ��ȯ�ϴ� ����
2. �Ű������� �Է¹��� �ΰ��� ������ ���� ���� ��ȯ�ϴ� ����
3. 3, 5�� �Է� �޾� ū�� ����ϱ�
4. -3, -5�� �Է� �޾� ������ ����ϱ�

[output]
3�� 5�� ū���� (��ȯ��) �̴�
-3�� -5�� ���� ���� (��ȯ��) �̴�


*/
