using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Animator ar;
    [SerializeField] private Player_Grounded gd;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            sr.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            sr.flipX = false;
        }

        if(!gd.isGrounded && rb.velocity.y <0)
        {
            ar.SetBool("Fall", true);
        }
        else
        {
            ar.SetBool("Fall", false);
        }
        if (!gd.isGrounded && rb.velocity.y > 0)
        {
            ar.SetBool("Jump", true);
        }
        else
        {
            ar.SetBool("Jump", false);
        }
        if (gd.isGrounded && rb.velocity.x != 0)
        {
            ar.SetBool("Run", true);
        }
        else
        {
            ar.SetBool("Run", false);
        }
    }
}
