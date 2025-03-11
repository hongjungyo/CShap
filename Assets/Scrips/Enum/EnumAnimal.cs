using UnityEngine;

//[1]동물들을 구분하는 열거형 생성

enum Animal
{
    Mouse,
    Cow,
    Tiger,
}
public class EnumAnimal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 열거형(Animal) 변수 선언하고 초기화
        Animal animal = Animal.Tiger;
        Debug.Log(animal);

        if(animal==Animal.Tiger)
        {
            Debug.Log("호랑이");
        }
        else if(animal == Animal.Cow)
        {
            Debug.Log("소");
        }
        else if (animal == Animal.Mouse)
        {
            Debug.Log("쥐");
        }
    }
}
