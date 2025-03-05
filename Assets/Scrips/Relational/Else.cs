using UnityEngine;

//만약 score가 60점 이상이면 "합격" 이라고 출력,
//만약 score가 60점 이상이 아니면 "불합격" 이라고 출력,
//스코어는 61점
public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        {
            int score = 59;

            //만약 score가 60점 이상이면
            if (score >= 60)        

            {
                //실행문 
                Debug.Log("합격");
            }
            else //조건식이 아니면
            {
                Debug.Log("불합격");
            }
            Debug.Log("종료");
        }
    }
}
