using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement player;
    public Animator animator;

    public float movePower = 10f;

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {

        Vector3 moveVelocity = Vector3.zero;
        animator.SetBool("isWalk", false);


        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;

            animator.SetFloat("posX", -1);
            animator.SetFloat("posY", 0);
            animator.SetBool("isWalk", true);

        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;

            animator.SetFloat("posX", 1);
            animator.SetFloat("posY", 0);
            animator.SetBool("isWalk", true);

        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            moveVelocity = Vector3.down;

            animator.SetFloat("posX", 0);
            animator.SetFloat("posY", -1);
            animator.SetBool("isWalk", true);

        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            moveVelocity = Vector3.up;

            animator.SetFloat("posX", 0);
            animator.SetFloat("posY", 1);
            animator.SetBool("isWalk", true);

        }
        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
}
