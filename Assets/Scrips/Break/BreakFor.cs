using UnityEngine;

// break; : �ݺ���(for, while)���� {}�� ���������� ��ɹ�
// �ݺ��� �ȿ��� break; ���� ������ ��� �������´�. �ݺ����� ���� �����Ѵ�.
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�ȳ��ϼ��並 5�� ����ϴ� ���α׷�
        //i = 2 �� �� for�� ���� 
        for(int i =0;  i < 5; i++)
        {
            Debug.Log("�ȳ��ϼ���");

            if(i==2)
            {
                break;
            }
        }
        // i=0 => 1<5 (��) -> ��� => 1 == 2 (����) => i:1 => i<5(��) => ���
        // i == 2(����) => 1:2 => i<5(��) => => ��� => i==2(��) =>break; => for�� ����
    }
}
