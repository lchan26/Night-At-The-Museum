using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimations : MonoBehaviour
{
    Animator anim;
    private Vector2 dir;
    private Vector2 lastdir;
    [SerializeField]
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        this.lastdir = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        this.dir = player.GetComponent<PlayerController>().getMovementDirectionAnim();

        if (this.dir == Vector2.down)
        {
            if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Down")))
            {
                anim.SetTrigger("MoveDown");
            }
        }

        else if (this.dir == Vector2.up)
        {
            if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Up")))
            {
                anim.SetTrigger("MoveUp");
            }
        }

        else if (this.dir == Vector2.right)
        {
            if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Right")))
            {
                anim.SetTrigger("MoveRight");
            }
        }

        else if (this.dir == Vector2.left)
        {
            if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Left")))
            {
                anim.SetTrigger("MoveLeft");
            }
        }

        else
        {
            anim.SetTrigger("Idle");
        }

    }
}
