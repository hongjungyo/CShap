using UnityEngine;

public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //무한 루프  - 무한 반복
        /*for(;;)
        {
        }*/
        /*
        while(true)
        {
        }
        */
        int number = 0;
        // number가 5이상이면 while문 종료
        while (true) //무한루프
        {
            //반복실행문
            Debug.Log(number);
            number++;

            if (number > 5)
            {
                break;
            }

        }
    }
}
