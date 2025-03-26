using UnityEngine;
namespace Override
{
    //부모 클래스
    public class Base
    {
        public virtual void work() => Debug.Log("부모가 일한다");

    }

    //자식 클래스
    public class Sub : Base
    {
        //sealed 키워드를 사용하여 재정의 봉인
        public override sealed void work()
        {
            Debug.Log("자식이 일한다.");
        }
    }
    //손자 클래스
    public class GrandSub : Sub
    {
        /*
        public override void work()
        {
            Debug.Log("손자가 일한다.");
        }
        */
        public void play() => Debug.Log("손자가 논다");
    }
}