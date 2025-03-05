using UnityEngine;

public class StringCompair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        string s2 = "Hello";

        //만약 s1 과 s2 이 같으면 Same이라고 출력

        if (s1 == s2)
        {
            Debug.Log("Same");
        }
        //만약 bin 값이  false이면 실행문을 실행
        bool bin = false;
        if (bin == false)
        {
            Debug.Log("bin:" +bin);

            //bin 값이 참이면 실행문을 실행
            if(!bin)
            {
                Debug.Log("!bin:" + !bin);

            }
        }
    }
}
