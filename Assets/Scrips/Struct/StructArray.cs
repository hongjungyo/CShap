using Unity.VisualScripting;
using UnityEngine;

//[1] ����ü ����, ���� : ���� �����͸� �����ϴ� ����ü �����

struct UserInfo
{
    public string name; //���̸�
    public int age;     //�� ����
    //......
}

public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UserInfo Info;
        Info.name = "ȫ�浿";
        Info.age = 20;

        PrintUserInfo(Info.name, Info.age);

        int n;
        n = 2;
        //[1]����ü�� �迭 ���� ����, ��Ҽ�(ũ��) ����
        UserInfo[] userInfos = new UserInfo[n];
        //[2] ����ü �迭 �ʱ�ȭ
        userInfos[0].name = "��λ�";
        userInfos[0].age = 22;

        userInfos[1].name = "�Ӳ���";
        userInfos[1].age = 33;
        
        for(int i =0; i < userInfos.Length; i++)
        {
            //PrintUserInfo(userInfos[i].name, userInfos[i].age);
            
        }


    }

    //�� ����� ����ϴ� �Լ�
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}���� ���̴� {age}�� �Դϴ�.");
    }

}
