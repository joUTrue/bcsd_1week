using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    private void Awake()
    {
        int[] arrays = new int[5];
        Debug.Log($"�迭�� Ÿ�� : {arrays.GetType()}");
        Debug.Log($"�迭�� �⺻ Ÿ�� : {arrays.GetType().BaseType}");

        for( int i = 0; i < arrays.Length; i++ )
        {
            arrays[i] = UnityEngine.Random.Range( 0, 5 );
            Debug.Log(arrays[i]);
        }

        Array.Sort( arrays );

        for( int i = 0;i < arrays.Length;i++ )
        {
            Debug.Log(arrays[i]);
        }
    }
}
