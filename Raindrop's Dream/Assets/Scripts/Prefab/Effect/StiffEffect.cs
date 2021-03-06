﻿/********************************************************************************* 
  *Author:AICHEN
  *Date:  2018-6-12
  *Description: 画面僵直效果
**********************************************************************************/
using System.Collections;
using UnityEngine;

public class StiffEffect : HitEffect
{
    [Header("僵直时间")]
    public float stiffTime;
    [Header("僵直动画播放速度")]
    public float stiffAnimatorSpeed;

    private float animatorSpeed;
    private Animator animator;
    public override void Show(GameObject _victim)
    {
        animator = _victim.GetComponent<Animator>();
        animatorSpeed = animator.speed;
        StartCoroutine(Stiff(_victim));
    }
    IEnumerator Stiff(GameObject obj)
    {
        animator.speed = stiffAnimatorSpeed;
        yield return new WaitForSeconds(stiffTime);
        animator.speed = animatorSpeed;
    }
}
