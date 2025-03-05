using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j != 3); //true && true
        Debug.Log("r:" +r);       //ture

        r = (i != 3) && (j == 3); //false && false
        Debug.Log("r:" +r);       //false

        r = (i >= 5);            //false
        Debug.Log("!r:" +!r);     //ture

        Debug.Log((1 == 1) ||(1 !=1)); //ture

        //
        bool bin1 = true;
        bool bin2 = false;

        Debug.Log(bin1 && bin2);    //true && false
        Debug.Log(bin1 || bin2);    //true || false


    }
}
