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
        Debug.Log(this.dir);
        if (this.dir == Vector2.down)
        {
            anim.SetTrigger("MoveDown");
            this.lastdir = this.dir;
        }

        if (this.dir == Vector2.up)
        {
            anim.SetTrigger("MoveUp");
            this.lastdir = this.dir;
        }

        if (this.dir == Vector2.right)
        {
            anim.SetTrigger("MoveRight");
            this.lastdir = this.dir;
        }

        if (this.dir == Vector2.left)
        {
            anim.SetTrigger("MoveLeft");
            this.lastdir = this.dir;
        }

        if (this.dir == Vector2.zero)
        {

        }
    }
}
