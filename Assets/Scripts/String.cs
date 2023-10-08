using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    private void Awake()
    {
        //서식
        int minutes = 1;
        int seconds = 15;

        Debug.Log(string.Format("기본 : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("왼쪽 맞춤 : {0, -5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("오른쪽 맞춤 : {0, 5}{1}{2}", minutes, ":", seconds));

        Debug.Log(string.Format("10진수 서식화 : {0:D}", 123));
        Debug.Log(string.Format("10진수 서식화(5자리) : {0:D5}", 123));

        Debug.Log(string.Format("16진수 서식화 : {0:x}", 0x00));
        Debug.Log(string.Format("16진수 서식화(10자리) : {0:x10}", 0x00));

        Debug.Log(string.Format("고정소수점 서식화 : {0:F}", 1.23));
        Debug.Log(string.Format("고정소수점 서식화(소수점 1자리) : {0:F1}", 1.23));

        Debug.Log(string.Format("콤마 구분 : {0:N}", 123456789));
        Debug.Log(string.Format("지수 : {0:E}", 123456789));

        DateTime dateTime = new DateTime(2023, 10, 08, 02, 45, 0);
        string str = dateTime.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)");
        Debug.Log(str);

        str = dateTime.ToString("yyyy-MM-dd- HH:mm:ss (dddd)");
        Debug.Log(str);

        //보간
        Debug.Log(string.Format("{0}{1}{2}", minutes, " : ", seconds));
        Debug.Log($"{minutes} : {seconds}");

        Debug.Log(string.Format("{0, -10:D5}", minutes));
        Debug.Log($"{minutes,-10:D5}");

        ////탐색
        string str2 = "hello world";
        int numeric = str2.IndexOf('o');
        Debug.Log($"o위치 {numeric+1} 번째");

        numeric = str2.LastIndexOf("o");
        Debug.Log($"o위치 뒤에서 {numeric}번째");
        
        bool isTrue = str2.StartsWith("hello");
        Debug.Log($"hello 시작 : {isTrue}");

        isTrue = str2.StartsWith("world");
        Debug.Log($"world 시작 : {isTrue}");
        
        isTrue = str2.EndsWith("hello");
        Debug.Log($"hello 끝 : {isTrue}");

        isTrue = str2.EndsWith("world");
        Debug.Log($"world 끝 : {isTrue}");

        isTrue = str2.Contains("he");
        Debug.Log($"he 포함 : {isTrue}");
    }
}
