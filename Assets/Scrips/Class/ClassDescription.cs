using UnityEngine;

public class ClassDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Run(); //�޼��� ȣ��:  ���� Ŭ������ �޼��� ȣ��
    }

    //ClassDescription ��� Ŭ������ Run() �޼���(�Լ�)
    void Run()
    {
        Debug.Log("ClassDescription ��� Ŭ������ Run �޼���");
    }
}

/*
Class(Ŭ����) - C# �⺻�� �Ǵ� ����
: �ϳ��� �̸����� ���� �ٸ� (������) �����͵�� �Լ����� ��� �����ϴ� �׸�(����)
:......
:����� ���� ������ ����

public class(Ŭ���� �̸�)
{

}

*/