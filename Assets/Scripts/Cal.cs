using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cal : MonoBehaviour
{
    private void Awake()
    {
        //�⺻
        int a = 3 + 4;
        int b = a - 2;
        int c = a * b;
        int d = c / 5;
        int e = d % 3;

        //�Ҵ�
        a += 9;
        a *= 4;
        a /= 8;
        a %= 3;
        a &= 5;
        a |= 2;
        a ^= 3;
        a <<= 2;
        a >>= 1;

        //����
        Debug.Log(a);
        Debug.Log(++a);
        Debug.Log(a++);

        //��
        Debug.Log($"{a}>{b}={a >b}");
        Debug.Log($"{a}<{b}={a <b}");
        Debug.Log($"{a}>={b}={a >=b}");
        Debug.Log($"{a}<={b}={a <=b}");
        Debug.Log($"{a}=={b}={a== b}");
        Debug.Log($"{a}!={b}={a !=b}");
    }
}
