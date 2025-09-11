using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 1.0f;

    private float y;
    private float x;

    void Update()
    {
        y = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(x,y)*Time.deltaTime*speed);
    }
}
