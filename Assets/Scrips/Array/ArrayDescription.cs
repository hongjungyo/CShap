using UnityEngine;

//Array(�迭) : �ϳ��� �̸����� ���� ������ ������ ������ ������ ���� �׸�
//������ Ÿ��[] ������ (�̸�); 
public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �迭 ����
        int[] numbers;

        //[2] �迭�� ��Ҽ� ���� - �׸� ���� ���� - ũ��
        numbers = new int[10];  //0 ~ n-1

        //[3] �迭�� ����, ���� - �ʱ�ȭ
        numbers[0] = 3840;
        numbers[1] = 2160;

        //������ ���
        Debug.Log(numbers[0] * numbers[1]);

    }
}
