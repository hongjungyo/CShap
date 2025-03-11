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

3행 3열의 2차원 배열을 만들고
초기화 하는데 행과 열의 인덱스가 같으면 1, 행과 열의 인덱스가 틀리면 0으로 저장하시오
저장하는 방법을 이중 For문을 이용

1, 0, 0
0, 0, 0,
0, 0, 0,

[출력]
arr[0, 0] : 1
arr[0, 1] : 0
....
arr[2, 2] :1
 */
