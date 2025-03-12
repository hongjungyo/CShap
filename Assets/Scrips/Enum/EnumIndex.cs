using UnityEngine;

//열거형 값을 정수형이나 문자열로 사용이 가능 

enum Animals
{
    Rabbit,
    Dragon,
    Snake,
    pig,
}
public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //열거형 변수 초기화
        Animals animal = Animals.Snake;
        int num = (int)animal;
        string str = animal.ToString();

        Debug.Log($"Animals.Snake: {num}, {str}");

    }
}
