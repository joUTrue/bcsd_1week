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
            Debug.Log("x는 짝");
        }
        else
        {
            Debug.Log("x는 홀");
        }

        if(x>5&&x<10)
        {
            Debug.Log("x는 5보다크고 10보다 작");
        }

        if (x > 90)
        {
            Debug.Log("x는 90보다큼");
        }
        else if (x > 80)
        {
            Debug.Log("x는 80보다큼");
        }
        else if (x>70)
        {
            Debug.Log("x는 70보다큼");
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
