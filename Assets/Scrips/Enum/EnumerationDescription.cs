using UnityEngine;

//[1]�켱������ �����ϴ� ������ ����(����, �����)
//����� ���� ������ ����

enum Priorty
{
    High,
    Nomal,
    Low,
}
public class EnumerationDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        //[2]������ ���� ���� �� �ʱ�ȭ
        //������ ������ ����Ǵ� ���� ���ǿ��� ������� ��� ���� �����ϴ�.

        Priorty High = Priorty.High;
        Priorty Nomal = Priorty.Nomal;
        Priorty Low = Priorty.Low;

        Debug.Log($"{High} {Nomal} {Low}");

    }
}

/*
Enumeration(������) : �ϳ��� �̸����� ���� �����ִ� ���� ���� ���� ������� ����

//����
enum (enum �̸�)
{
    �����.
    �����.
    �����.
    ......
}
*/