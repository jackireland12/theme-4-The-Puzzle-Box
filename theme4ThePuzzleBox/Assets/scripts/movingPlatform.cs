using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    Animator animator;
    private bool play;
    private bool coliding;
    batteryMovement bm;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        bm = GameObject.FindGameObjectWithTag("Player").GetComponent<batteryMovement>();
        // animator.speed = 0.0f;
        coliding = false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && coliding == true)
        {
            if (play == true)
            {
                play = false;
            }
            else
            {
                play = true;
            }
            playAni();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        coliding = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        coliding= false;
    }
    
    void playAni()
    {
        if (play == true)
        {
            animator.speed = 1;
        }
        else
        {
            animator.speed = 0;
        }
    }
}
