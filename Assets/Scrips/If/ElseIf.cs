using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SCORE�� 90�� �̻��̸� A 80�� �̻��̸� B, 70�� �̻��̸� C,
        //60�� �̻��̸� D �������� F

        int score = 59;
        char grade = 'A';

        if(score>=90)
        {
            grade = 'A';
            Debug.Log($"{grade} ����");
        }
        else if(score >= 80)
        {
            grade = 'B';
            Debug.Log($"{grade} ����");
        }
        else if (score >= 70)
        {
            grade = 'C';
            Debug.Log($"{grade} ����");
        }
        else if (score >= 60)
        {
            grade = 'D';
            Debug.Log($"{grade} ����");
        }
        else
        {
            grade = 'F';
            Debug.Log($"{grade} ����");
        }
        Debug.Log("����");

    }
}
