using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cal : MonoBehaviour
{
    private void Awake()
    {
        //기본
        int a = 3 + 4;
        int b = a - 2;
        int c = a * b;
        int d = c / 5;
        int e = d % 3;

        //할당
        a += 9;
        a *= 4;
        a /= 8;
        a %= 3;
        a &= 5;
        a |= 2;
        a ^= 3;
        a <<= 2;
        a >>= 1;

        //증감
        Debug.Log(a);
        Debug.Log(++a);
        Debug.Log(a++);

        //비교
        Debug.Log($"{a}>{b}={a >b}");
        Debug.Log($"{a}<{b}={a <b}");
        Debug.Log($"{a}>={b}={a >=b}");
        Debug.Log($"{a}<={b}={a <=b}");
        Debug.Log($"{a}=={b}={a== b}");
        Debug.Log($"{a}!={b}={a !=b}");
    }
}
