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
            s = "금메달";
            Debug.Log($"{s}를 수상하였습니다.");
        }
        else
        {
            if (score >= 80)
            {
                s = "은메달";
                Debug.Log($"{s}를 수상하였습니다.");
            }
            else
            {
                if (score >= 80)
                {
                    s = "동메달";
                    Debug.Log($"{s}를 수상하였습니다.");
                }
                else
                {
                    s = "노메달";
                    Debug.Log($"{s}를 수상하였습니다.");
                }

            }
        }
    }
}
