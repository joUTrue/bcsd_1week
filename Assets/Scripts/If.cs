using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    private void Awake()
    {
        int x = 10;
        if(x % 2 ==0)
        {
            Debug.Log("x�� ¦");
        }
        else
        {
            Debug.Log("x�� Ȧ");
        }

        if(x>5&&x<10)
        {
            Debug.Log("x�� 5����ũ�� 10���� ��");
        }

        if (x > 90)
        {
            Debug.Log("x�� 90����ŭ");
        }
        else if (x > 80)
        {
            Debug.Log("x�� 80����ŭ");
        }
        else if (x>70)
        {
            Debug.Log("x�� 70����ŭ");
        }

        x /= 10;
        switch(x)
        {
            case 10:
                Debug.Log("A+");
                break;
            case 9:
                Debug.Log("A");
                break;
            case 8:
                Debug.Log("B+");
                break;
            default:
                Debug.Log("B");
                break;
        }
    }
}
