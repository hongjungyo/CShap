using System;
using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double pi = 3.141592; //64��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ    
        float f = 3.14f; //32��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ
        decimal d = 12.34m; //128��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log(pi);
        Debug.Log(f);
        Debug.Log(d);

        double doublemin = double.MinValue;
        double doubleMax = double.MaxValue;

        float floatMin = float.MinValue;
        float floatMax = float.MaxValue;


        Debug.Log("double �ּҰ�:" + Double.MinValue);
        Debug.Log("double �ִ밪:" + Double.MaxValue);
        Debug.Log("float �ּҰ�:" + float.MinValue);
        Debug.Log("float �ִ밪:" + float.MaxValue);
    }
}
