using UnityEngine;
namespace Inheritance
{
    //자식클래스 Sub
    public class SubClass : Base
    {
        public void Doing()
        {
            Debug.Log("Sub 클래스에 정의된 메서드");
        }
    }
}