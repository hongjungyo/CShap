using UnityEngine;

public class StringCompair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        string s2 = "Hello";

        //���� s1 �� s2 �� ������ Same�̶�� ���

        if (s1 == s2)
        {
            Debug.Log("Same");
        }
        //���� bin ����  false�̸� ���๮�� ����
        bool bin = false;
        if (bin == false)
        {
            Debug.Log("bin:" +bin);

            //bin ���� ���̸� ���๮�� ����
            if(!bin)
            {
                Debug.Log("!bin:" + !bin);

            }
        }
    }
}
