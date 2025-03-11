using UnityEngine;

//내장형 구조체 사용
public class DateTimeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 현재시간 출력
        Debug.Log($"현재시간:{System.DateTime.Now}");

        // 현재 년, 월, 일, 시, 분, 초 출력
        Debug.Log($"현재 연:{System.DateTime.Now.Year}");
        Debug.Log($"현재 월:{System.DateTime.Now.Month}");
        Debug.Log($"현재 일:{System.DateTime.Now.Day}");
        Debug.Log($"현재 시:{System.DateTime.Now.Hour}");
        Debug.Log($"현재 분:{System.DateTime.Now.Minute}");
        Debug.Log($"현재 초:{System.DateTime.Now.Second}");

        //[2] DateTime 구조체의 변수를 선언 해서 사용
        System.DateTime Now = System.DateTime.Now;
        Debug.Log(Now.Date);
        Debug.Log(Now.ToLongTimeString());

    }
}
