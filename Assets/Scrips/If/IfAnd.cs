using UnityEngine;

//&&, ||
public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;
        
        //조건식 2개 : number가 1234와 같은가, number가 1000이상인가
        //두가지 조건을 모두 만족하면 맞습니다. 출력 
        if (number==1234 && number>1000) 
        {
            Debug.Log("맞습니다");
        }

        //조건식 2개 : number가 1234와 같은가, number가 1000이하인가
        //두가지 조건중 하나라도 만족하면 맞습니다. 출력 
        if (number == 1234 || number <= 1000)
        {
            Debug.Log("맞습니다");
        }
    }
}
