using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeChange : MonoBehaviour
{
    private void Awake()
    {
        //크기 다른 정수 형변환
        sbyte byteValue = 10;
        int intValue = (int)byteValue;

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("int Data : " + intValue);

        int intValue2 = 130;
        sbyte byteValue2 = (sbyte)intValue2;//오버플로우 발생


        Debug.Log("byte Data : " + byteValue2);
        Debug.Log("int Data : " + intValue2);

        //부호가 다른 형변환
        sbyte sbyteValue = 10;
        byte byteValue3 = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue3);

        sbyte sbyteValue2 = -10;
        byte byteValue4 = (byte)sbyteValue2;

        Debug.Log("sbyteValue : " + sbyteValue2);
        Debug.Log("byteValue : " + byteValue4);

        byte byteValue5 = 130;
        sbyte sbyteValue3 = (sbyte)byteValue5;

        Debug.Log("sbyteValue : " + sbyteValue3);
        Debug.Log("byteValue : " + byteValue5);

        //크기 다른 실수 형변환
        float floatValue = 3.14159f;
        double doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        float floatValue2 = 0.1f;
        double doubleValue2 = (double)floatValue2;

        Debug.Log("floatValue : " + floatValue2);
        Debug.Log("doubleValue : " + doubleValue2);

        //실수 정수 변환
        float floatValue3 = 0.9f;
        int intValue3 = (int)floatValue3;

        Debug.Log("floatValue : " + floatValue3);
        Debug.Log("intValue : " + intValue3);

        float floatValue4 = 1.1f;
        int intValue4 = (int)floatValue4;

        Debug.Log("floatValue : " + floatValue4);
        Debug.Log("intValue : " + intValue4);

        //문자 숫자 변환
        int intValue5 = 10;
        float floatValue5 = 1.234f;
        string stringValue = "23";

        Debug.Log("intValue : " + intValue5);
        Debug.Log("floatValue : " + floatValue5);
        Debug.Log("stringValue : " + stringValue);

        int intValue6 = int.Parse(stringValue);
        string stringValue2 = "23.45";
        float floatValue6 = float.Parse(stringValue2);

        Debug.Log("intValue : " + intValue6);
        Debug.Log("floatValue : " + floatValue6);
        Debug.Log("stringValue : " + stringValue2);
    }
}
