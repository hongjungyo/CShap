using UnityEngine;

public class NumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float f = 3.14f;
        double pi = 3.14;
        decimal d = 3.14m;

        Debug.Log("float:" + f);
        Debug.Log("double:" + pi);
        Debug.Log("decimal:" + d);


    }
}

/*
[Q]
실수형 값 float 3.14, double 3.14, decimal 3.14 값 출력 

[out put]

float:3.14
double: 3.14
decimal:3.14
*/
