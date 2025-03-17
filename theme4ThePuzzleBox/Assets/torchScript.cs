using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class torchScript : MonoBehaviour
{
    private bool on = false;
    private bool coliding;
    public GameObject torchl;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && coliding == true)
        {
            on = !on;
            if (on == true)
            {
                torchl.SetActive(false);
            }
            else
            {
                torchl.SetActive(true);
            }
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
