using UnityEngine;
// VaiableNote (변수) : 프로그램에서 사용하는 데이터를 저장해 놓는 그릇
public class VaiableNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 만들기(선언)
        int i; // i 변수 이름으로 (정수형)변수 만들기
        //[2] 변수의 값을 저장하기(대입, 할당, 초기화)
        i = 1234;
        Debug.Log(i);
        //[3]변수에 들어가 있는 값 참조
    }
}
