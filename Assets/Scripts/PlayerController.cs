using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    float speed = 5;

    private LinkedList<Vector2> keyPresses = new LinkedList<Vector2>();
    
    private Vector2 movement = Vector2.zero;

    public GameObject securityGuard;


    // Start is called before the first frame update
    void Start()
    {

        
    }

    public Vector2 getMovementDirection(){
        return movement;
    }

    public Vector2 getMovementDirectionAnim()
    {
        return movement / speed;
    }

    // Update is called once per frame
    void Update()
    {
    


        Vector2 dir = Vector2.zero;

        bool changedInput = false;

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp("w")) {
            // move up
            removeDirection(Vector2.up);
            changedInput = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp("s")) {
            removeDirection(Vector2.down);
            changedInput = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp("a")) {
            removeDirection(Vector2.left);
            changedInput = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp("d")) {
            removeDirection(Vector2.right);
            changedInput = true;
        }

        //GetKeyDown
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w")) {
            addDirection(Vector2.up);
            changedInput = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown("s")) {
            addDirection(Vector2.down);
            changedInput = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown("a")) {
            addDirection(Vector2.left);
            changedInput = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown("d")) {
            addDirection(Vector2.right);
            changedInput = true;
        }

        if (keyPresses.Count != 0) {
            if(gameObject.GetComponent<Rigidbody2D>().velocity == Vector2.zero && !changedInput && keyPresses.Count != 1)
            {
                movement = speed * keyPresses.First.Next.Value;
                Vector2 first = keyPresses.First.Value;
                removeDirection(first);
                Vector2 second = keyPresses.First.Value;
                removeDirection(second);
                addDirection(first);
                addDirection(second);
            }
        movement = speed * keyPresses.First.Value;
        }
        else movement = Vector2.zero;

        gameObject.GetComponent<Rigidbody2D>().velocity = movement;
    }

    public void addDirection(Vector2 direction){
        keyPresses.AddFirst(direction);
    }

    public void removeDirection(Vector2 direction) {
        LinkedListNode<Vector2> target = keyPresses.Find(direction);
        keyPresses.Remove(target);
        }

    public void OnTriggerEnter2D(Collider2D col) {
        //print("a");
        if (col.gameObject.tag == "SecurityGuard") {
            transform.position = new Vector3(-10.23f, -12.51f, 0);
        }
        if (col.gameObject.tag == "SecurityCamera") {
            securityGuard.GetComponent<Pathfinding.Patrol>().enabled = false;
            securityGuard.GetComponent<Pathfinding.AIDestinationSetter>().enabled = true;
        }
    }
}       
