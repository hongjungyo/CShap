using UnityEngine;

public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string userName = "Redplus";
        string inputName = "redplus";

        //[1] (==) �����ڸ� ���
        if(userName.ToLower() == inputName.ToLower())
        {
            Debug.Log("[1]�����ϴ�");
        }
        //[2] string.Equal() �޼��� ���
        if (userName.ToLower() == inputName.ToLower())
        {
            Debug.Log("[1]�����ϴ�");
        }

    }
}
