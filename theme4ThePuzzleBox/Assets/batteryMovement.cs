using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;



    //Rigidbody2D rb;
    //public float speed;
    //public float jumphight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //float horrizontalInput = Input.GetAxis("Horizontal");
        ////float VerticalInput = Input.GetAxis("Vertical");
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Jump();
        //}
        //rb.velocity = new Vector2(horrizontalInput * speed, 0);
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

    //void Jump()
    //{
    //    Debug.Log("jump");
    //    rb.AddForce(new Vector2 (rb.velocity.x , jumphight));
        
    //}
}
