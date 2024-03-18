using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingAnimantion : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Set the "IsRunning" parameter to true
            animator.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.W)) // Optional: Stop running when W key is released
        {
            // Set the "IsRunning" parameter to false
            animator.SetBool("Walk", false);
        }
    }
}
