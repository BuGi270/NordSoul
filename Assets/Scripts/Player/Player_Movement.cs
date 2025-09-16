using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Player_Grounded gd;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float force = 15f;
    [SerializeField] private int air_jumps = 2;
    [SerializeField] Text text;

    private int jump_count = 0;
    private Vector2 movement;
    float test;
    void Update()
    {
        test += 1*Time.deltaTime;
        text.text = test.ToString();
        if(Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
        }
        else
        {
            movement.x = 0;
        }

        movement.y = 0;

        if (Input.GetKeyDown(KeyCode.Space)&& jump_count < air_jumps)
        {
            rb.velocity = new Vector2(rb.velocity.x, force);
            jump_count++;
        }
        if (gd.isGrounded && jump_count >= 1)
        {
            jump_count = 0;
        }

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
    }
    private void LateUpdate()
    {
        
    }
}    
