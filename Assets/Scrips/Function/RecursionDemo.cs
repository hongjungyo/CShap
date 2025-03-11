using UnityEngine;

//���丮�� ���ϴ� �˰���
public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(4 * 3 * 2 * 1);

        //For Factorial
        Debug.Log(FactorialFor(4));


    }

    int FactorialFor(int n)
    {
        int result = 1;
        for (int i = 0; i <= n; i++)
        {
            result *= i;
        }
        return (result);

    }
    
    
    //�����Լ� �̿� Factorial �� ���ϱ�
    int Factorial(int n)
    {
        //���� ���� �κ�
        if(n==1)
        {
            return 1;
        }

            //��� ȣ�� �κ�

        return n * Factorial(n - 1);
    }
    /*
            4 * Factorial(3);
                3 * Factorial(2);
                    2 * Factorial(1);
                        1 * Factorial(0);
                            0 * Factorial(-1);
                                
    

     */

}
/*
����Լ� : �Լ��� �ڽ��� �ڵ��� �ѿ��� �ڱ��ڽ��� �ٽ� ȣ��(���ȣ��)�ϴ� �Լ�
- ����Լ� �谳���� : �Ű������� ���� ������ �ȴ�.
-����Լ� �ڵ� ��� �ȿ��� ����Լ��� ���� �� �� �ִ� ������ �ʿ��ϴ�.

*/
