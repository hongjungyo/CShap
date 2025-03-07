using UnityEngine;

//Index(인덱스) : 몇번째의 방, [ ]안에 들어가는 변수, 값
public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int[] numbers = { 1, 2, 3 };

        int index = 0;

        Debug.Log(numbers[index++]); // => numbers[0]=>1, index:1
        Debug.Log(numbers[index++]); // => numbers[1]=>1, index:2
        Debug.Log(numbers[index++]); // => numbers[2]=>1, index:3

        Debug.Log(numbers[index--]); // => index:2, numbers[2]=>3
        Debug.Log(numbers[index--]); // => index:1, numbers[1]=>2
        Debug.Log(numbers[index--]); // => index:0, numbers[0]=>1
    }
}
