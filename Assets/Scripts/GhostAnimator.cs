using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAnimator : MonoBehaviour
{
    Animator anim;
    private int dir;
    //private int lastdir;
    [SerializeField]
    private GameObject ghost;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //this.lastdir = 1;
    }

    // Update is called once per frame
    void Update()
    {
        this.dir = ghost.GetComponent<SecurityGuardController>().getMovementDirection();

        if(this.dir >= 0)
        {
            anim.SetBool("Moving", true);
            if(this.dir == 2)
            {
                anim.SetBool("FacingX", true);
                anim.SetBool("FacingPositive", true);
            }
            else if(this.dir == 3)
            {
                anim.SetBool("FacingX", true);
                anim.SetBool("FacingPositive", false);
            }
            else if(this.dir == 0)
            {
                anim.SetBool("FacingX", false);
                anim.SetBool("FacingPositive", true);
            }
            else
            {
                anim.SetBool("FacingX", false);
                anim.SetBool("FacingPositive", false);
            }
        }
        else
        {
            anim.SetBool("Moving", false);
        }
    }
}
