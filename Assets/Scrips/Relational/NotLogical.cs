using UnityEngine;

//NotOperator(부정 연산자, Not): 참이면 거짓이고, 거짓이면 참으로 변환
public class NotLogical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 참일 때
        Debug.Log(!true); //=>false

        //[2] 거짓일 때
        Debug.Log(!false); //=>true

        //[3]
        bool bin = false;

        Debug.Log(!bin);    //true
        Debug.Log(!!bin);    //false
        Debug.Log(!(!(!bin)));    //true


    }
}
