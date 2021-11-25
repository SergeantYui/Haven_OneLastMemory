using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeys : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool rightPressed = Input.GetKey(KeyCode.D);
        bool leftPressed = Input.GetKey(KeyCode.A);
        bool backPressed = Input.GetKey(KeyCode.S);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);
        bool jumpPressed = Input.GetKey(KeyCode.Space);

        if (forwardPressed || rightPressed || leftPressed || backPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (!(forwardPressed || rightPressed || leftPressed || backPressed))
        {
            animator.SetBool("isWalking", false);
        }

        if ((forwardPressed || rightPressed || leftPressed || backPressed) && runPressed)
        {
            animator.SetBool("isRunning", true);
        }

        if (((forwardPressed || rightPressed || leftPressed || backPressed) && !runPressed) || (!(forwardPressed || rightPressed || leftPressed || backPressed) && runPressed))
        {
            animator.SetBool("isRunning", false);
        }

    }



}
