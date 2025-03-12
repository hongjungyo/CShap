using UnityEngine;

//String 클래스, StringBuilder 클래스를 이용하여 문자열 다루기
public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string massege = "HelloWorld";
        Debug.Log(massege);

        //[1] 대문자
        Debug.Log(massege.ToUpper());

        //[2] 소문자

        Debug.Log(massege.ToLower());

        //[3] 바꾸기
        Debug.Log(massege.Replace("Hello", "안녕하세요").Replace("World", "세계"));



    }
}
