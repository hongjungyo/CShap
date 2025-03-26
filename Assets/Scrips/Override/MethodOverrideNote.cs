using UnityEngine;
namespace Override
{
    public class MethodOverrideNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Developer 클래스의 객체 만들기
            Developer dev = new Developer();
            Debug.Log($"{dev}");

            WebDeveloper wdev = new WebDeveloper();
            Debug.Log(wdev);

            MobileDeveloper mdev = new MobileDeveloper();
            Debug.Log(mdev);
        }
    }
}