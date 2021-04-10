using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void walk(bool move)
    {
        anim.SetBool("Movement",move);
    }
    public void punch_1()
    {
        anim.SetTrigger("Punch1");
    }

    public void punch_2()
    {
        anim.SetTrigger("Punch2");
    }

    public void punch_3()
    {
        anim.SetTrigger("Punch3");
    }

    public void kick_1()
    {
        anim.SetTrigger("Kick1");
    }

    public void kick_2()
    {
        anim.SetTrigger("Kick2");
    }
    public void EnemyAttack(int attack)
    {
        if (attack == 0) 
        {
            anim.SetTrigger("Attack1");
        }
        if (attack == 1) 
        {
            anim.SetTrigger("Attack2");
        }
        if (attack == 2) 
        {
            anim.SetTrigger("Attack3");
        }
    }

    public void idleAnimation()
    {
        anim.Play("Enemy1_Idle");
    }

    public void KnockDown()
    {
        anim.SetTrigger("Knockdown");
    }
    public void standUp()
    {
        anim.SetTrigger("StandUp");
    }
    public void Hit()
    {
        anim.SetTrigger("Hit");
    }
    public void Death()
    {
        anim.SetTrigger("Death");
    }

}
