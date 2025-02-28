using UnityEngine;

//bool(불): 불형, 논리 자료형, 참(true), 거짓(false) 값 저장
public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] bool 변수 선언하고 초기화
        bool bin = true;
        Debug.Log("bin: " + bin);

        bool isout = false;
        Debug.Log("isout: " + isout);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
