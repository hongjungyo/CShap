using UnityEngine;

//[1]�������� �����ϴ� ������ ����

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
        //[2] ������(Animal) ���� �����ϰ� �ʱ�ȭ
        Animal animal = Animal.Tiger;
        Debug.Log(animal);

        if(animal==Animal.Tiger)
        {
            Debug.Log("ȣ����");
        }
        else if(animal == Animal.Cow)
        {
            Debug.Log("��");
        }
        else if (animal == Animal.Mouse)
        {
            Debug.Log("��");
        }
    }
}
