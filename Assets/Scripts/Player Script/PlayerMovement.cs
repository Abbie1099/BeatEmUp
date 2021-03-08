using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float walkspeed = 300.0f;
    private float horizontal;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(-10.0f, 0.0f, 0.0f) * walkspeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(10.0f, 0.0f, 0.0f) * walkspeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
        }
        //transform.Translate(new Vector3(-horizontal, 0.0f, 0.0f) * walkspeed * Time.deltaTime);
        //if (Input.GetAxis("Horizontal") < 0)
        //{
        //    transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
        //}
        //else
        //{
        //    transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        //}
    }
}
