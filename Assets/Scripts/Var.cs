using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Var : MonoBehaviour
{
    private void Awake()
    {
        //정수
        sbyte byteValue = -128;
        byte ubyteValue = 255;
        short shortValue = -32768;
        ushort ushortValue = 65535;
        int intValue = -2147483648;
        uint uintValue = 4294967295;
        long longValue = -long.MaxValue;
        ulong ulongValue = ulong.MaxValue;
        char charValue = 'k';

        Debug.Log("byte Data : " + byteValue );
        Debug.Log("ubyte Data : " + ubyteValue );
        Debug.Log("short Data : " +  shortValue);
        Debug.Log("ushort Data : " +  ushortValue);
        Debug.Log("int Data : " +  intValue);
        Debug.Log("uint Data : " +  uintValue);
        Debug.Log("long Data : " +  longValue);
        Debug.Log("ulong Data : " +  ulongValue);
        Debug.Log("char Data : " +  charValue);

        //실수
        float floatValue01 = 3.141592653589793238462643383279502884197169399375105820974944f;
        float floatValue02 = 31.41592653589793238462643383279502884197169399375105820974944f;
        double doubleValue = 3.141592653589793238462643383279502884197169399375105820974944;
        decimal decimalValue = 3.141592653589793238462643383279502884197169399375105820974944m;

        Debug.Log("float01 Data : " +  floatValue01);
        Debug.Log("float02 Data : " + floatValue02); ;
        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " +  decimalValue);

        //문자열, 불리안
        string stringValue = "hello";
        bool boolValue = true;

        Debug.Log("string Data : "+stringValue);
        Debug.Log("bool Data : "+ boolValue);
    }
}
