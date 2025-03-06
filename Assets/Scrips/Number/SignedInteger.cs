using System.ComponentModel;
using UnityEngine;

public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sbyte iSbyte = 127; //8��Ʈ ��ȣ�� �ִ� ������ ���� ����� �ʱ�ȭ
        short iint16 = 32767; //16��Ʈ ��ȣ�� �ִ� ������ ���� ����� �ʱ�ȭ
        int iint32 = 2147483647; //32��Ʈ ��ȣ�� �ִ� ������ ���� ����� �ʱ�ȭ
        long iint64 = 9223372036845775807;//64��Ʈ ��ȣ�� �ִ� ������ ���� ����� �ʱ�ȭ
        
        
        //UnSignedInteger
        //byte ibyte = 255;
        //ushort iuint16 = 65535; //16��Ʈ ��ȣ�� ���� ������ ���� ����� �ʱ�ȭ
        //uint iuint32 = 4294967295;//32��Ʈ ��ȣ�� ���� ������ ���� ����� �ʱ�ȭ
        //ulong iuint64 = 18446744073709551615; //64��Ʈ ��ȣ�� ���� ������ ���� ����� �ʱ�ȭ

        Debug.Log("sbyte:" + iSbyte);
        Debug.Log("short:" + iint16);
        Debug.Log("int:" + iint32);
        Debug.Log("long:" + iint64);
    }
}

/*
1 BIt 0,1
1 Byte: 8 bit
0000 0000 ->0 
0000 0001 ->1
0000 0010 ->2
0000 0011 ->3
0000 0100 ->4

8bit
(+, -, 0)
sbyte : -128 ~ 127

(+, 0)
byte : 0~ 255

*/
/*
SignedInteger : (+, -) ��ȣ�� �ִ� ������ ������ ����(Ÿ��)
UnSignedInteger : (+, -) ��ȣ�� ���� ������ ������ ����(Ÿ��)
*/