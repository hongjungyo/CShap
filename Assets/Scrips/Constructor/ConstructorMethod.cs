using UnityEngine;

namespace Constructor
{
    public class ConstructorMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Student 클래스의 인스턴스 생성
            Student student = new Student();
        }
    }
}