using System;
using UnityEngine;

public class NullDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //널 가능 형식
        //bool bin = null;
        Nullable<bool> bin = null;
        Debug.Log(bin.HasValue);

        bin = false;
        Debug.Log(bin.HasValue);

        //Nullable<int> -> int?
        //Nullable<float> -> float?
        //Nullable<int> ni -> int?

        int? ni = null;
        ni = 10;
        Debug.Log(ni);
    }
}
