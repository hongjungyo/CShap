using UnityEngine;

//TypeConversion(���ĺ�ȯ)
public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Long�� ���� L �� �����ϰ� Long �� ������ ���� �� �ִ� ���� ū ���� �����մϴ�.
        long l = long.MaxValue;
        Debug.Log("l�� ��:"+l); //L ���� �ܼ�â�� ����϶�
        //int�� ���� i�� �����ϰ� l���� �����Ѵ�.
        int i = (int)l;
        Debug.Log("i�� ��:" + i);

    }
}
