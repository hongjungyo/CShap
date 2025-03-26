using UnityEngine;
namespace Inheritance04
{
    //부모 클래스
    public class BaseClass : System.Object // 모든 클래스는 Object 클래스로 부터 상속
    {
        protected void PrintLog()
        {
            Debug.Log("부모 클래스의 메서드에서 호출");
        }
    }
}