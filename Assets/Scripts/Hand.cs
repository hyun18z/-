using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public string handName; // 손 종류
    public float range; // 공격범위
    public int damage; // 공격력
    public float workSpeed; // 작업속도
    public float attackDelay; // 공격딜레이
    public float attackDelayA; // 공격활성화 시점
    public float attackDelayB; // 공격비활성화 시점

    public Animator anim; // 애니메이션
    
}
