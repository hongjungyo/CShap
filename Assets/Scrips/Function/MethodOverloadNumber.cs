using UnityEngine;

//MethodOverload(�޼��� �����ε�, �Լ� ���� ����)
//������ �̸��� �޼��带 �Ű������� �޸��ؼ� ������ �����ϴ� �� 
public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        printNumber(1234);
        printNumber(1234L);
        printNumber(1234F);


    }

    //�Ű������� ���ڸ� �Է¹޾� ����ϴ� �Լ� : PrintNumber
    //int Ÿ���� ������ �Ű������� �Է¹޾� ���
    void printNumber(int number)
    {
        Debug.Log($"Int32: {number}");
    }
    
    //long Ÿ���� ������ �Ű������� �Է¹޾� ���
    void printNumber(long number)
    {
        Debug.Log($"Int32: {number}");
    }

    //float Ÿ���� ������ �Ű������� �Է¹޾� ���
    void printNumber(float number)
    {
        Debug.Log($"Int32: {number}");
    }
}
