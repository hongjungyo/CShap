using System.Linq;
using UnityEngine;
using System.Collections.Generic;
using System.Globalization;

public class LinqSort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 배열을 오름차순으로 정렬   
        string[] colors = { "red", "Green", "Blue" };

         colors.OrderBy(s => s);

        //오름차순
        IEnumerable<string> sortedColors =colors.OrderBy(s => s);

        foreach (var color in sortedColors)
        {
            Debug.Log(color);
        }

        //내림차순
        IEnumerable<string> sortedColors2 = colors.OrderByDescending(s => s);

        foreach (var color in sortedColors2)
        {
            Debug.Log(color);
        }



    }
}
