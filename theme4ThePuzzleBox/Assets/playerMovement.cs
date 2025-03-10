using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector2 vel;
    public Camera cam;
    public float playerScale;
    public float camScale;
    public float speedScale;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horrizontalInput =  Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");




        rb.velocity = new Vector2(horrizontalInput* speed, VerticalInput*speed);
        //rb.velocity = rb.velocity * speed;
       if (Input.GetButtonDown("Fire1"))
        {
            small();
        }
        
    }
    void small()
    {
        Debug.Log("smalll");
        transform.localScale = transform.localScale * playerScale;
        cam.orthographicSize = cam.orthographicSize * camScale;
        speed = speed* speedScale;
    }

}
