using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private PlayerAnimator enAnim;
    public Rigidbody rb;
    public float speed = 0.0f;

    public Transform playerTarget;

    public float attack_Distance = 1.0f;
    public float chase_player_After_Attack = 1.0f;
    private float currentAttackTime;
    private float defaultAttackTime = 2f;
    private bool followPlayer;
    private bool attackPlayer;
    // Start is called before the first frame update
    void Start()
    {
        followPlayer = true;
        currentAttackTime = defaultAttackTime;
    }
    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }
    void FollowTarget()
    {
        if (!followPlayer)
        {
            return;
        }
        if (Vector3.Distance(transform.position, playerTarget.position) > attack_Distance)
        {
            transform.LookAt(playerTarget);
            rb.velocity = transform.forward * speed;
            if (rb.velocity.sqrMagnitude != 0)
            {
                enAnim.walk(true);
            }
        }
        else if (Vector3.Distance(transform.position, playerTarget.position) <= attack_Distance)
        {
            rb.velocity = Vector3.zero;
            enAnim.walk(false);

            followPlayer = false;
            attackPlayer = true;
        }
    }
    void attack()
    {
        if(!attackPlayer)
        {
            return;
        }
        currentAttackTime += defaultAttackTime;
        if(currentAttackTime>defaultAttackTime)
        {
            enAnim.EnemyAttack(Random.Range(0, 3));
            currentAttackTime = 0.0f;
        }
        if(Vector3.Distance(transform.position,playerTarget.position)>attack_Distance+chase_player_After_Attack)
        {
            attackPlayer = false;
            followPlayer = true;
        }
    }
}
