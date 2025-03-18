using UnityEngine;

public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClassOne.Hi();
        ClassTwo.Hi();
        ClassTwo two = new ClassTwo();
        two.Hello();
    }
}
