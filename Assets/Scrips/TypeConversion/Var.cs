using System;
using UnityEngine;

//var : 암시적으로 형식화된 로컬 변수
//var 선언시 데이터 초기화를 반드시 한다.
public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name ="홍길동"; //변수에 입력되는 값("홍길동")을 보고  name 변수를 tring 형식으로 결정 

        var version = 8.0; //변수에 입력되는 값(8.0)을 보고  version 변수를 double 형식으로 결정  

        var car = 1;      ///변수에 입력되는 값(1)을 보고  car 변수를 int 형식으로 결정 
        Debug.Log(name);
        Debug.Log(name.GetType());

        Debug.Log(version);
        Debug.Log(version.GetType());
        
        Debug.Log(car);
        Debug.Log(car.GetType());
        
    }
}
