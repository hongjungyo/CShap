using Unity.VisualScripting;
using UnityEngine;

//�ΰ��� ������ ���̸� ���� ������ ���Ͻÿ�
public class NumDifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 2;
        int second = 1;
        int diff = 0; //�μ� ������ ��

        if(first >= second)
        {
            diff = first - second;
            Debug.Log(diff);
        }
        else
        {
            diff = second - first;
            Debug.Log(diff);

        }

    }
}
