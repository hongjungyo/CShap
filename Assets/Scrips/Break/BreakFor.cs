using UnityEngine;

// break; : 반복문(for, while)에서 {}를 빠져나오는 명령문
// 반복문 안에서 break; 문을 만나면 즉시 빠져나온다. 반복문을 강제 종료한다.
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //안녕하세요를 5번 출력하는 프로그램
        //i = 2 일 때 for문 종료 
        for(int i =0;  i < 5; i++)
        {
            Debug.Log("안녕하세요");

            if(i==2)
            {
                break;
            }
        }
        // i=0 => 1<5 (참) -> 출력 => 1 == 2 (거짓) => i:1 => i<5(참) => 출력
        // i == 2(거짓) => 1:2 => i<5(참) => => 출력 => i==2(참) =>break; => for문 종료
    }
}
