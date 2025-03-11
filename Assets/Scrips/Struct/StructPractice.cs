using UnityEngine;

// 중첩 구조체: 구조체 안에 구조체
// 성적을 관리하는 구조체 만들기
//과목의 점수를 관리하는 구조체 선언 

struct Score
{
    public int kor; //국어점수
    public int eng; //영어점수
}

//학생 정보를 관리하는 구조체 선언 = 성적 포함
struct student
{
    public int number;  //학생 번호
    public string name; //학생 이름
    public Score score; //과목 점수 Score  구조체 : 중첩구조 
}

public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 구조체 변수 선언 및 요소수(크기) 생성
        student[] students = new student[3];

        //[2]
        students[0].number = 1;
        students[0].name = "홍길동";
        students[0].score.kor = 100;
        students[0].score.eng = 90;

        students[1].number = 2;
        students[1].name = "백두산";
        students[1].score.kor = 90;
        students[1].score.eng = 80;

        students[2].number = 3;
        students[2].name = "임꺽정";
        students[2].score.kor = 90;
        students[2].score.eng = 75;
        //[3]
        for (int i =1; i < students.Length; i++)
        {
            Debug.Log($"{students[i].number}번 - {students[i].name}{"\n"}국어{students[i].score.kor}점{"\n"}영어:{students[i].score.eng}");
        }
    }
}
