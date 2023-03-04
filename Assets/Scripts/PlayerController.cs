using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    float speed = 5;

    private LinkedList<Vector2> keyPresses = new LinkedList<Vector2>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    


        Vector2 dir = Vector2.zero;

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp("w")) {
            // move up
            removeDirection(Vector2.up);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp("s")) {
            removeDirection(Vector2.down);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp("a")) {
            removeDirection(Vector2.left);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp("d")) {
            removeDirection(Vector2.right);
        }

        //GetKeyDown
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w")) {
            addDirection(Vector2.up);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown("s")) {
            addDirection(Vector2.down);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown("a")) {
            addDirection(Vector2.left);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown("d")) {
            addDirection(Vector2.right);
        }

        if (keyPresses.Count != 0) {
        gameObject.GetComponent<Rigidbody2D>().velocity = speed * keyPresses.First.Value;
        }
        else gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    public void addDirection(Vector2 direction){
        keyPresses.AddFirst(direction);
    }

    public void removeDirection(Vector2 direction) {
        LinkedListNode<Vector2> target = keyPresses.Find(direction);
        keyPresses.Remove(target);
        }
}       
