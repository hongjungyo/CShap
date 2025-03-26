using UnityEngine;
namespace Override
{
    public class InheritancePractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //HyunDai 클래스의 인스턴스 생성
            HyunDai hd = new HyunDai();
            Debug.Log($"{hd.Style}");
            hd.Go();
            hd.Back();
            hd.Left();

            HyunDai hdE = new HyunDai(CarType.전기);
            Debug.Log($"{hd.Style}");
            hd.Go();

            //테슬라 인스턴스
            Tesla ts = new Tesla();
            Debug.Log($"{ts.Style}");
            ts.Go();
            ts.Back();
            ts.Left();

            //미래 인스턴스
            Mirae mr = new Mirae();
            mr.Go();
            


        }
    }
}