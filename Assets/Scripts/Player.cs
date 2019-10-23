using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float dirX, moveSpeed;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("HP"))
        {
            dirX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x + dirX, transform.position.y);
        }


        if (dirX != 0 && !anim.GetCurrentAnimatorStateInfo(0).IsName("HP"))
        {
            anim.SetBool("isWalking", true);
        } else
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetButtonDown("HP") && !anim.GetCurrentAnimatorStateInfo(0).IsName("HP"))
        {
            anim.SetBool("isWalking", false);
            anim.SetTrigger("isHeavyPunching");
        }
    }
}
