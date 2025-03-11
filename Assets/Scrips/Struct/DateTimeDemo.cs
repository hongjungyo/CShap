using UnityEngine;

//������ ����ü ���
public class DateTimeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ����ð� ���
        Debug.Log($"����ð�:{System.DateTime.Now}");

        // ���� ��, ��, ��, ��, ��, �� ���
        Debug.Log($"���� ��:{System.DateTime.Now.Year}");
        Debug.Log($"���� ��:{System.DateTime.Now.Month}");
        Debug.Log($"���� ��:{System.DateTime.Now.Day}");
        Debug.Log($"���� ��:{System.DateTime.Now.Hour}");
        Debug.Log($"���� ��:{System.DateTime.Now.Minute}");
        Debug.Log($"���� ��:{System.DateTime.Now.Second}");

        //[2] DateTime ����ü�� ������ ���� �ؼ� ���
        System.DateTime Now = System.DateTime.Now;
        Debug.Log(Now.Date);
        Debug.Log(Now.ToLongTimeString());

    }
}
