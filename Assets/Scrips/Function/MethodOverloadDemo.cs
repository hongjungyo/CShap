using UnityEngine;

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();
        Hi("�ݰ����ϴ�");
        Hi("�����մϴ�", 3);
    }

    //�λ��ϴ� �Լ� �����ϱ� : Hi
    //�Ű������� ���� �Լ�
    void Hi()
        {
        Debug.Log("�ȳ��ϼ���");
        }

    //�Ű�����(Message)�� �ִ� �Լ�
    void Hi(string Message)
    {
        Debug.Log(Message);
    }

    //�Ű������� �Է¹��� (Message)��  ���� (count)Ƚ�� ��ŭ �λ�

    void Hi(string Message, int count)
    {
        for(int i =0; i< count; i++)
        {
            Debug.Log("�ȳ��ϼ���");

        }
    }



}
