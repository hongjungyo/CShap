using UnityEngine;

//����(static) �޼��� ȣ��, �ν��Ͻ�(Instance) �޼��� ȣ�� 
public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����(static) �޼��� ȣ��: Ŭ���� �̸�()(ClassMember). �ż����̸�(StaticMember())
        ClassMember.StaticMember();

        //[2] �ν��Ͻ�(Instance) �޼��� ȣ��
        //ȣ����
        //Ŭ������ ��ü(��ü,Instance) ����(Ŭ������ ���� ����) 
        //new Ű���带 ����� ���ο� ��ü ����
        //(Ŭ���� �̸�)��ü�̸� = new Ŭ���� �̸�();
        //(��ü�̸�). �޼����̸�();
        //���: ��ü ����(new ���)=> ��ü.�ν��Ͻ� �޼���();
        ClassMember member =new ClassMember();
        member.InstanceMethod();


    }
}
