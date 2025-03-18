using UnityEngine;

//가제(Object, 오브젝트): 설계도인 클래스로부터 만들어진 하나의 인스턴스(실제, 구성요소)
//[1]class code 이름의 클래스(class)
public class  classcode
{
    //Empty
}

public class ClassAndObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ClassCode 클래스의 개체(Object, 인스턴스) 만들기
        classcode objectcode1 = new classcode();
        Debug.Log(objectcode1.GetHashCode());

        //[3] ClassCode 클래스의 개체(Object, 인스턴스) 만들기
        classcode objectcode2 = new classcode();
        Debug.Log(objectcode2.GetHashCode());


    }

}
