using UnityEngine;

//���� score�� 60�� �̻��̸� "�հ�" �̶�� ���,
//���� score�� 60�� �̻��� �ƴϸ� "���հ�" �̶�� ���,
//���ھ�� 61��
public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(1 !=1 )
        {
            //���๮ 1
             //Debug.Log("���ǽ��� ���̸� ���๮ 1�� ���� �մϴ�.");
        }
        else
        {
            //���๮ 2
            Debug.Log("���ǽ��� �����̸� ���๮ 2�� ���� �մϴ�.");

        }
        //���๮ 3
    }
}

/*
 else �� 
���� ���ǽ��� ���̸� ���๮ 1�� �����ϰ�  \���๮ 2��  �������� �ʴ´�. 
���ǽ��� �����̸� ���๮ 2�� �����ϰ�  ���๮ 1��  �������� �ʴ´�. 

If(���ǽ�)
{
    //���๮ 1
}
else
{
    //���๮ 2
}
    //���๮ 3

1. ���ǽ��� ���̸� 
���๮ 1 -> ���๮ 3


2. ���ǽ��� �����̸�  
���๮ 2 -> ���๮ 3 

*/