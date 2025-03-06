using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SCORE가 90점 이상이면 A 80점 이상이면 B, 70점 이상이면 C,
        //60점 이상이면 D 나머지는 F

        int score = 59;
        char grade = 'A';

        if(score>=90)
        {
            grade = 'A';
            Debug.Log($"{grade} 학점");
        }
        else if(score >= 80)
        {
            grade = 'B';
            Debug.Log($"{grade} 학점");
        }
        else if (score >= 70)
        {
            grade = 'C';
            Debug.Log($"{grade} 학점");
        }
        else if (score >= 60)
        {
            grade = 'D';
            Debug.Log($"{grade} 학점");
        }
        else
        {
            grade = 'F';
            Debug.Log($"{grade} 학점");
        }
        Debug.Log("종료");

    }
}
