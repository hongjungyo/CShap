using UnityEngine;

//Random Ŭ���� : �������� ���õ� ������, �޼������ �ִ� Ŭ����
public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //RandomŬ����(����Ŭ����)�� ��ü ����
        System.Random random = new System.Random();

        //������ ������ ���ϱ�
        Debug.Log(random.Next(1,9));
        //0,1,2,3,4�� �ϳ��� �� ���ϱ�
    }
}
