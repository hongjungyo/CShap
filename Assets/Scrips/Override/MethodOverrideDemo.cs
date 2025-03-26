using UnityEngine;
namespace Override
{

    public class MethodOverrideDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Base 클래스의 인스턴스 생성
            Base parent = new Base();
            parent.work();

            //Sub 클래스의 인스턴스 생성
            Sub child = new Sub();
            child.work();

            //GrandSub 클래스의 인스턴스 생성
            GrandSub grandchild = new GrandSub();
            grandchild.work();


        }
    }
}