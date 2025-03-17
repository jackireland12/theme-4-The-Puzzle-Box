using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class torchScript : MonoBehaviour
{
    private bool on = false;
    private bool coliding;
    public GameObject torchl;

    batteryMovement bm;

    private void Start()
    {
        bm = GameObject.FindGameObjectWithTag("Player").GetComponent<batteryMovement>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && coliding == true)
        {
            on = !on;
            if (on == true)
            {
                torchl.SetActive(false);
                bm.batteryLevel = bm.batteryLevel -1;
            }
            else
            {
                torchl.SetActive(true);
                bm.batteryLevel = bm.batteryLevel +1;
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
