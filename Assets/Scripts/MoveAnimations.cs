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
        if (this.dir == Vector2.zero)
        {
            anim.SetBool("Idle", true);
        }

        if (!(this.dir == this.lastdir))
        {
            if (this.lastdir == Vector2.down)
            {
                anim.SetBool("MoveDown", false);
            }

            else if (this.lastdir == Vector2.up)
            {
                anim.SetBool("MoveUp", false);
            }

            else if (this.lastdir == Vector2.right)
            {
                anim.SetBool("MoveRight", false);
            }

            else if (this.lastdir == Vector2.left)
            {
                anim.SetBool("MoveLeft", false);
            }
        }

        if (this.dir == Vector2.down)
        {
            anim.SetBool("MoveDown", true);
            anim.SetBool("Idle", false);
            this.lastdir = Vector2.down;
        }

        else if (this.dir == Vector2.up)
        {
            anim.SetBool("MoveUp", true);
            anim.SetBool("Idle", false);
            this.lastdir = Vector2.up;
        }

        else if (this.dir == Vector2.right)
        {
            anim.SetBool("MoveRight", true);
            anim.SetBool("Idle", false);
            this.lastdir = Vector2.right;
        }

        else if (this.dir == Vector2.left)
        {
            anim.SetBool("MoveLeft", true);
            anim.SetBool("Idle", false);
            this.lastdir = Vector2.left;
        }

    }
}
