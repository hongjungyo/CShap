using UnityEngine;

//Continue���� �ݺ������� Continue���� ������ Continue�� �Ʒ��� �ִ� ���๮�� �������� �ʰ� 
// ���� �ݺ����� ���ǽ��� �Ǻ��� ���� �ݺ����� �����մϴ�. 
public class ContinueFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1���� 5���� Ȧ���� ����ϴ� ���α׷�
        /*for(int i =1; i <=5; i++)
        {
            if(i %2 !=0)
            Debug.Log(i);
        }
        */
        for (int i = 1; i <= 5; i++)
        {
            if (i % 2 == 0)
            {
                continue; //���� �ݺ� �������� �ݺ����� �����ϰ� ���� �ݺ������� �̵��϶�
            }
                Debug.Log(i);
        }

    }
}
