using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Const : MonoBehaviour
{
    /*
    const int PlayerIdle = 0;
    const int PlayerMove = 1;
    const int PlayerAttack = 2;
    */

    enum PlayerState
    {
        Idle,
        Move,
        Attack
    }
    PlayerState state = PlayerState.Idle;

    private void Awake()
    {
        switch (state)
        {
            case PlayerState.Idle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerState.Move:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerState.Attack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }
    }
}
