using UnityEngine;

//���� score�� 60�� �̻��̸� "�հ�" �̶�� ���,
//���� score�� 60�� �̻��� �ƴϸ� "���հ�" �̶�� ���,
//���ھ�� 61��
public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        {
            int score = 59;

            //���� score�� 60�� �̻��̸�
            if (score >= 60)        

            {
                //���๮ 
                Debug.Log("�հ�");
            }
            else //���ǽ��� �ƴϸ�
            {
                Debug.Log("���հ�");
            }
            Debug.Log("����");
        }
    }
}
