using UnityEngine;
namespace Constructor
{
    public class ConstructorLog
    {
        public ConstructorLog()
        {

            Debug.Log("기본 생성자 호출");

        }
            //string 매개변수가 있는 생성자 선언
            public ConstructorLog(string massege)
        {
            Debug.Log($"오버로드된 생성자 실행: {massege}");
        }
    
    }
}
    
