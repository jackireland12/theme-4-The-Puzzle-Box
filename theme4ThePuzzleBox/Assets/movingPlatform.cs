using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    Animator animator;
    private bool play;
    private bool coliding;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
       // animator.speed = 0.0f;
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
