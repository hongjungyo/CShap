using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����

        int x = 2;

        //switch (����) : �������� �� �Ǻ�
        switch(x)
        {
            case 1:
                Debug.Log("x�� 1�Դϴ�."); //[1] ���๮1
                break;
            case 2:
                Debug.Log("x�� 2�Դϴ�."); //[2] ���๮1
                break;
            case 3:
                Debug.Log("x�� 3�Դϴ�."); //[3] ���๮1
                break;
        }
        //[4] ���๮
        Debug.Log("���α׷� ����");
    }
}
/*
 switch�� : ���ǹ� - ���ù� 

switch(����) : �������� �� �Ǻ� 
{
    case 1��:
        //���๮ 1
        break:

    case 2��:
        //���๮ 2
        break:

    case 3��:
        //���๮ 3
        break:
   case 4��:
        //���๮ 4
        break:

    default  //��� case�� �ƴϸ�
        //���๮ 5
        break:
    
}

if(���ǽ�) : ���ǽ� �� ���� �Ǻ� 
{
    ���๮1
}
else
{
     ���๮2
}


*/ 