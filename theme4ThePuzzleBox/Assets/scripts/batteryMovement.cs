using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 10f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    public int batteryLevel;

    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        batteryLevel = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Jump")&& IsGrounded())
        {
            Debug.Log("jump");
            rb.velocity= new Vector2(rb.velocity.x, jumpingPower);
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            Debug.Log("longjump");
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y *0.5f);
        }
        
            Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

    }
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f){ 
        
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        
        };
    }

    
}
