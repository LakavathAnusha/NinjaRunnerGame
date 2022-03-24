using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemt : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            animator.SetTrigger("isSlice");
            rb.AddForce(Vector2.up * jumpForce);
        }
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * jumpForce, rb.velocity.y);
      if(Input.GetKeyDown(KeyCode.A))
        {
          
        }
      //
    }
}
