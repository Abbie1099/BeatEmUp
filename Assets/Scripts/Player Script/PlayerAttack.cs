using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public PlayerAnimator animator;
    // Start is called before the first frame update
   public enum ComboState
    { 
        NONE,
        PUNCH_1,
        PUNCH_2,
        PUNCH_3,
        KICK_1,
        KICK_2
    }
    private bool activateTimerToReset;
    public float default_Combo_Timer = 0.4f;
    public float current_Combo_Timer;
    private ComboState current_Combo_State;
    void Start()
    {
        current_Combo_Timer = default_Combo_Timer;
        current_Combo_State = ComboState.NONE;
    }

    // Update is called once per frame
    void Update()
    {
        ComboAttacks();
        resetCombo();
        
    }
    void ComboAttacks()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            current_Combo_State++;
            activateTimerToReset = true;
            current_Combo_Timer = default_Combo_Timer;
            if (current_Combo_State == ComboState.PUNCH_3 || current_Combo_State == ComboState.KICK_1 || current_Combo_State == ComboState.KICK_2)
            {
                return;
            }
            if (current_Combo_State == ComboState.PUNCH_1)
            {
                animator.punch_1();
            }
            if (current_Combo_State == ComboState.PUNCH_2)
            {
                animator.punch_2();
            }
            if (current_Combo_State == ComboState.PUNCH_3)
            {
                animator.punch_3();
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (current_Combo_State == ComboState.KICK_2||current_Combo_State==ComboState.PUNCH_3 )
            {
                return;
            }
            if(current_Combo_State==ComboState.NONE||current_Combo_State==ComboState.PUNCH_1||current_Combo_State==ComboState.PUNCH_2)
            {
                current_Combo_State = ComboState.KICK_1;
            }
            else if(current_Combo_State==ComboState.KICK_1)
            {
                current_Combo_State++;
            }
            activateTimerToReset = true;
            current_Combo_Timer = default_Combo_Timer;
            if(current_Combo_State==ComboState.KICK_1)
            {
                animator.kick_1();
            }
            if(current_Combo_State==ComboState.KICK_2)
            {
                animator.kick_2();
            }
        }
    }
        void resetCombo()
        {
            if(activateTimerToReset)
            {
                current_Combo_Timer -= Time.deltaTime;
                if(current_Combo_Timer<=0.0f)
                {
                    current_Combo_State = ComboState.NONE;
                    activateTimerToReset = false;
                    current_Combo_Timer = default_Combo_Timer;
                }
            }
        }
    }
