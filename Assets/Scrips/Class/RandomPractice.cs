using System;
using UnityEngine;


//로또 번호 생성기
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random random = new System.Random();
        int[] numbers = new int[6];
        int index = 0;

        while (index < 6)
        {
            int number = random.Next(1, 46);
            if (Array.IndexOf(numbers, number) == -1)
            {
                numbers[index] = number;
                index++;
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log($"[{i + 1}] : {numbers[i]}");


        }
    }
   


}
/*
[Q]

로또 번호 생성기 만들기
[1] 6개 번호
[2] 1~45사이의 랜덤 번호
[3] 중복 숫자 X




*/