using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w")) {
            // move up
            dir += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s")) {
            // move down
            dir += Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) {
            // move left
            dir += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")) {
            // move right
            dir += Vector2.right;
        }

        gameObject.GetComponent<Rigidbody2D>().velocity = speed * dir.normalized;
    }
}
