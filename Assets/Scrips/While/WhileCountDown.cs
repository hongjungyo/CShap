using UnityEditorInternal;
using UnityEngine;

public class WhileCountDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1부터 5까지 1씩 증가
        //초기식
        int i = 1;

        while(i<=5) //조건식
        {
            //반복 실행문
            Debug.Log($"카운트 다운{i}");

            i++;
        }

        Debug.Log("---------------------------");
        int j = 1;

        while (j <= 5) //조건식
        {
            //반복 실행문
            Debug.Log($"카운트 다운{(6-j)}");

            j++;
        }
    }
}
