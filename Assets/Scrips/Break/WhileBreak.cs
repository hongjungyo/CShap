using UnityEngine;

public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        int n = 10;
        int goal = 22;

        //�ʱ��
        int i = 1;
        
        while (true)
        {
            if (i <= n)
            {
                sum += i;
                
                if (sum >= goal)
                {
                    break;
                }

                //������
                i++;   
            }
            Debug.Log($"���� {sum}");
        }
    }
}
