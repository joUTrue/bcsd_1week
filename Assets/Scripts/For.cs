using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    private void Awake()
    {
        //for
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

        for (int i = 0;i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                Debug.Log($"{i},{j}");
            }
        }
        //while
        int result = 0;
        int index = 1;
        while(index<10)
        {
            result += index;
            index++;
        }
        Debug.Log($"1부터 9까지의 합 : {result}" );
    }
}
