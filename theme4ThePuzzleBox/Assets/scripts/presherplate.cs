using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presherplate : MonoBehaviour
{
    [SerializeField] private bool coliding;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        coliding = true;
        playAni();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        coliding = false;
        playAni();
    }
    void playAni()
    {
        animator.SetTrigger("press");

    }
}
