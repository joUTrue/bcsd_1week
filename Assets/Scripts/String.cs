using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    private void Awake()
    {
        //����
        int minutes = 1;
        int seconds = 15;

        Debug.Log(string.Format("�⺻ : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("���� ���� : {0, -5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("������ ���� : {0, 5}{1}{2}", minutes, ":", seconds));

        Debug.Log(string.Format("10���� ����ȭ : {0:D}", 123));
        Debug.Log(string.Format("10���� ����ȭ(5�ڸ�) : {0:D5}", 123));

        Debug.Log(string.Format("16���� ����ȭ : {0:x}", 0x00));
        Debug.Log(string.Format("16���� ����ȭ(10�ڸ�) : {0:x10}", 0x00));

        Debug.Log(string.Format("�����Ҽ��� ����ȭ : {0:F}", 1.23));
        Debug.Log(string.Format("�����Ҽ��� ����ȭ(�Ҽ��� 1�ڸ�) : {0:F1}", 1.23));

        Debug.Log(string.Format("�޸� ���� : {0:N}", 123456789));
        Debug.Log(string.Format("���� : {0:E}", 123456789));

        DateTime dateTime = new DateTime(2023, 10, 08, 02, 45, 0);
        string str = dateTime.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)");
        Debug.Log(str);

        str = dateTime.ToString("yyyy-MM-dd- HH:mm:ss (dddd)");
        Debug.Log(str);

        //����
        Debug.Log(string.Format("{0}{1}{2}", minutes, " : ", seconds));
        Debug.Log($"{minutes} : {seconds}");

        Debug.Log(string.Format("{0, -10:D5}", minutes));
        Debug.Log($"{minutes,-10:D5}");

        ////Ž��
        string str2 = "hello world";
        int numeric = str2.IndexOf('o');
        Debug.Log($"o��ġ {numeric+1} ��°");

        numeric = str2.LastIndexOf("o");
        Debug.Log($"o��ġ �ڿ��� {numeric}��°");
        
        bool isTrue = str2.StartsWith("hello");
        Debug.Log($"hello ���� : {isTrue}");

        isTrue = str2.StartsWith("world");
        Debug.Log($"world ���� : {isTrue}");
        
        isTrue = str2.EndsWith("hello");
        Debug.Log($"hello �� : {isTrue}");

        isTrue = str2.EndsWith("world");
        Debug.Log($"world �� : {isTrue}");

        isTrue = str2.Contains("he");
        Debug.Log($"he ���� : {isTrue}");
    }
}
