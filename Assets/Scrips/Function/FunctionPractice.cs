using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((Add(5,3)));
        Debug.Log((Subtract(5, 3)));
        Debug.Log((Multiply(5, 3)));
        Debug.Log((Device(5, 3)));
        Debug.Log((Remainder(5, 3)));
        Hi("");
    }

    //ȭ��ǥ �Լ�, ���ٽ�, ����� �Լ�
    int Add(int x, int y) => x + y;
        /*
    {
        return x + y;
    }
        */

    int Subtract(int x, int y) => x - y;
    /*
{
    return x - y;
}
    */
    int Multiply(int x, int y) => x * y;

    /*
    {
        return x * y;
    }
    */

    int Device(int x, int y) => x / y;
    /*
    {
        return x / y;
    }
    */
    int Remainder(int x, int y) => x % y;
    /*
    {
        return x % y;
    }
    */

    void Hi(string msg) => Debug.Log("�ȳ��ϼ���");
}

/*
[Q]
��Ģ������ ���ϴ� �Լ� �����

�ΰ��� ������ �Է� �޾� +, -, /, *, % ����Ͽ�
������� ��ȯ�ϴ� �Լ� �����
add, subtract, multiply, device, remainder

�Է°�: 5, 3
[output]





*/
