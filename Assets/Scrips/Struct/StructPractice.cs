using UnityEngine;

// ��ø ����ü: ����ü �ȿ� ����ü
// ������ �����ϴ� ����ü �����
//������ ������ �����ϴ� ����ü ���� 

struct Score
{
    public int kor; //��������
    public int eng; //��������
}

//�л� ������ �����ϴ� ����ü ���� = ���� ����
struct student
{
    public int number;  //�л� ��ȣ
    public string name; //�л� �̸�
    public Score score; //���� ���� Score  ����ü : ��ø���� 
}

public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����ü ���� ���� �� ��Ҽ�(ũ��) ����
        student[] students = new student[3];

        //[2]
        students[0].number = 1;
        students[0].name = "ȫ�浿";
        students[0].score.kor = 100;
        students[0].score.eng = 90;

        students[1].number = 2;
        students[1].name = "��λ�";
        students[1].score.kor = 90;
        students[1].score.eng = 80;

        students[2].number = 3;
        students[2].name = "�Ӳ���";
        students[2].score.kor = 90;
        students[2].score.eng = 75;
        //[3]
        for (int i =1; i < students.Length; i++)
        {
            Debug.Log($"{students[i].number}�� - {students[i].name}{"\n"}����{students[i].score.kor}��{"\n"}����:{students[i].score.eng}");
        }
    }
}
