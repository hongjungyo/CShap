using UnityEngine;

//RelationalOperator(������ ������, �� ������)
//<(����), <=(�۰ų� ����), >(ŭ), >=(ũ�ų� ����), ==(����), !=(�ٸ�)
//��� :true(��), false(����)
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y); //x(3)��  y(5)���� ������? -> true
        Debug.Log(x <= y); //x(3)��  y(5)���� �۰ų� ������? -> true
        Debug.Log(x > y); //x(3)��  y(5)���� ū��? -> false
        Debug.Log(x >= y); //x(3)��  y(5)���� ũ�ų� ������? -> false
        Debug.Log(x == y); //x(3)��  y(5)���� ������? -> false
        Debug.Log(x != y); //x(3)��  y(5)���� �ٸ���? -> true

        Debug.Log("AAA" == "aaa"); //AAA�� aaa�� ������-> false

    }
}
