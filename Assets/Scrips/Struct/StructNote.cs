using UnityEngine;


//�� ���� �������� �����ϴ� ����ü

struct BusinessCard
{
    public string name;
    public int age;
    public string address;
}

public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BusinessCard myCard;

        myCard.name = "ȫ�浿";
        myCard.age = 20;
        myCard.address = "����� ������";

        Debug.Log($"�̸�:{myCard.name}{"\n"}����:{myCard.age}{"\n"}�ּ�:{myCard.address}");

    }
}
