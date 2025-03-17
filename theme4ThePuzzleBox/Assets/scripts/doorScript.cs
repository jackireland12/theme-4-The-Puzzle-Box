using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   
public class doorScript : MonoBehaviour
{
    Animator animator;
    private bool coliding;
    batteryMovement bm;

    
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        bm = GameObject.FindGameObjectWithTag("Player").GetComponent<batteryMovement>();
        animator.speed = 0.0f;
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && coliding == true)
        {
            animator.speed = 1.0f;
            animator.SetTrigger("door");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        coliding = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        coliding = false;
    }
}
