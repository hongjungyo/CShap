using UnityEngine;

public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(int i = 0; i < 3; i++) �ݺ�Ƚ��: 3
        //for(int i = 1; i < 4; i++ )  �ݺ�Ƚ��: 4 - 1
        //for(int i = 1; i <= 3; i++ ) �ݺ�Ƚ��: 3 - 1 + 1

        /*for (int i = 0; i < 3; i++)
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");
        }
        */
        //[1] �ʱ��
        int i = 0;

        while(i < 3)
        {
            Debug.Log("�ȳ��ϼ���");
            
            //������
            i++;
        }

        //int i =0 -> ���ǽ� �Ǻ�(i:0) �� -> ��� -> ������ i:1 ->���ǽ� �Ǻ�(i:1) �� -> ��� -> ������ i:2 ->
        //���ǽ� �Ǻ�(i:2) ��->���->������ i:3 ->���ǽ� �Ǻ�(i:3) ���� -> ����

    }
}
/*
While�� -> �ݺ���

���ǽ��� true�̸� �ݺ����� �����Ѵ�.
���ǽ��� false�̸� While���� �����Ѵ�.

While(���ǽ�)
{
    //�ݺ� ���๮
    
    //���ǽĿ� ���� ���� ������
}

���ǽ� �Ǻ�(��) => �ݺ��� ���� => ���ǽ� �Ǻ�(��) => �ݺ��� ���� => 


*/