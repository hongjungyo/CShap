using UnityEngine;

public class SqureClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Squre Ŭ������ ����(static) �޼��� GetName() ȣ��
        //���� �޼��� ȣ�� ���: Ŭ���� �̸�()(Squre). �ż����̸�(GetName())
        string name = Squre.GetName();
        Debug.Log(name);
    }
}
