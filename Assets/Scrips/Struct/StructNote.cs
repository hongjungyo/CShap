using UnityEngine;


//고객 명함 데이터의 관리하는 구조체

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

        myCard.name = "홍길동";
        myCard.age = 20;
        myCard.address = "서울시 강동구";

        Debug.Log($"이름:{myCard.name}{"\n"}나이:{myCard.age}{"\n"}주소:{myCard.address}");

    }
}
