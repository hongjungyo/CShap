using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int[] score = { 90, 65, 70, 50, 95 };

        double average = 0;
        int sum = 0;
        int count = 0;

        for (int i = 0; i < score.Length; i++)
        {
            if (score[i] >= 70 && score[i] <= 90)
            {
                sum += score[i];
                count++;
            }
        }
        if(count>0)
        {
            average = sum / (double)count;
        }
        Debug.Log($"평균점수:{average:0.00}");
    }
        /*
        [Q]
         입력데이터{90, 65, 70, 50, 95}
         국어점수중 70점 이상이고 95 이하인 점수들의 평균을 구하라
        [out put]
        평균점수:average
        */
}
