using UnityEngine;

//���� score�� 60�� �̻��̸� "�հ�" �̶�� ���,
//���ھ�� 61��
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;

        //���ǹ� 
        if (score >= 60)        //���ǹ��� ���̸� ��� �ȿ� �ִ� ���๮ ����

        {
            //���๮ 
            Debug.Log("�հ�");
        }
        
    }
}

/*
if�� - ���ǹ� 
���ǽ��� ���� ���� ���๮�� ����˴ϴ�.
���ǽ��� �����̸� ���๮�� �������� �ʽ��ϴ�.

//���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶�  
{   
    //���๮ 1
    //���๮ 2
    // ........
}

if(bool)
{   
    //���๮ 1
    //���๮ 2
    // ........
}

*/