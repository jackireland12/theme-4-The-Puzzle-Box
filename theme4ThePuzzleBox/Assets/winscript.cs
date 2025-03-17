using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winscript : MonoBehaviour
{

    public GameObject canvsa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("work");
        canvsa.SetActive(true);
    }
}
