using UnityEngine;

//
//String Interpolation (���ڿ� ������)
public class StringInterpolation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "���ڿ�������";
        Debug.Log("message: " + message); //[1] ���ڿ� ���ϱ� ����
        Debug.Log($"message: {message}"); //[2] ���ڿ� ������

        //string.Format
        string msg = string.Format("{0}��, {1}", "ȫ�浿", "�ȳ��ϼ���");
        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
