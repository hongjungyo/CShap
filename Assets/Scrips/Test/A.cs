using Unity.VisualScripting;
using UnityEngine;
//클래스(A) 만들기
public class A
{
    //필드(멤버변수) string 배열 선언하고 { 일, 월, 화, 수, 목, 금, 토 } 값으로 초기화 하기
    private string[] weekdays = new string[] { "일", "월", "화", "수", "목", "금", "토" };

   
    //인스턴스 멤버 함수 만들기 : 필드에서 선언된 배열 값을 출력하는 기능 구현
    public void PrintWeekdays()
    {
        for (int i = 0; i < weekdays.Length; i++)
        {
            Debug.Log(weekdays[i]);
        }
    }
    //정적(static) 멤버 함수 만들기 : 두 개의 정수를 매개 변수로 받아서 더하기 한 후 합을 결과 값으로 반환하는 기능 구현
    public static int number(int x, int y)
    {
        return x + y;
    }
}


