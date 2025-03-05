using Unity.VisualScripting;
using UnityEngine;

//두개의 정수의 차이를 양의 정수로 구하시오
public class NumDifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 2;
        int second = 1;
        int diff = 0; //두수 차이의 값

        if(first >= second)
        {
            diff = first - second;
            Debug.Log(diff);
        }
        else
        {
            diff = second - first;
            Debug.Log(diff);

        }

    }
}
