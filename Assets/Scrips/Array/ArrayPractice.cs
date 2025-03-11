using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    arr[i, j] = 1; 
                }
                else
                {
                    arr[i, j] = 0; 
                }
                Debug.Log($"arr[{i}, {j}] : {arr[i, j]}");
            }
        }


    }
}

/*
 [Q]

3�� 3���� 2���� �迭�� �����
�ʱ�ȭ �ϴµ� ��� ���� �ε����� ������ 1, ��� ���� �ε����� Ʋ���� 0���� �����Ͻÿ�
�����ϴ� ����� ���� For���� �̿�

1, 0, 0
0, 0, 0,
0, 0, 0,

[���]
arr[0, 0] : 1
arr[0, 1] : 0
....
arr[2, 2] :1
 */
