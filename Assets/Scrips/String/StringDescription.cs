using UnityEngine;

//String Ŭ����, StringBuilder Ŭ������ �̿��Ͽ� ���ڿ� �ٷ��
public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string massege = "HelloWorld";
        Debug.Log(massege);

        //[1] �빮��
        Debug.Log(massege.ToUpper());

        //[2] �ҹ���

        Debug.Log(massege.ToLower());

        //[3] �ٲٱ�
        Debug.Log(massege.Replace("Hello", "�ȳ��ϼ���").Replace("World", "����"));



    }
}
