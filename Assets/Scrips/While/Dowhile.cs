using UnityEngine;

public class Dowhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* int i = 0;
        do
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

            i++;
        } while (i < 3);
       */

      int i = 0;
     
        do
        {
          //�ݺ� ���๮
          Debug.Log("�ȳ��ϼ���");

          i++;
        } while (i < 3);
     
    }
}
/*
 
dowhile �� - �ݺ��� 
���� �ݺ� ���๮�� 1�� �����Ѵ�.
���ǽ��� true�̸� �ݺ����� �����Ѵ�.
���ǽ��� false�̸� While���� �����Ѵ�.

do
{
    //�ݺ� ���๮
} while ()


*/