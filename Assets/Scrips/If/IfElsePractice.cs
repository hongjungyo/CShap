using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        string s = "0";

        if(score >=90)
        {
            s = "�ݸ޴�";
            Debug.Log($"{s}�� �����Ͽ����ϴ�.");
        }
        else
        {
            if (score >= 80)
            {
                s = "���޴�";
                Debug.Log($"{s}�� �����Ͽ����ϴ�.");
            }
            else
            {
                if (score >= 80)
                {
                    s = "���޴�";
                    Debug.Log($"{s}�� �����Ͽ����ϴ�.");
                }
                else
                {
                    s = "��޴�";
                    Debug.Log($"{s}�� �����Ͽ����ϴ�.");
                }

            }
        }
    }
}
