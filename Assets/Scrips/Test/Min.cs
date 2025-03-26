using UnityEngine;
using System.Linq;
public class Min : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] num = new int[] { -2, -5, -3, -7, -1 };
        
        Debug.Log(num.Min());
    }
}
