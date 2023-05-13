using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInTrigger : MonoBehaviour
{
    private bool playerNearby = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool PlayerNearby()
    {
        return playerNearby;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerNearby = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerNearby = false;
        }
    }

    private void OnMouseEnter()
    {
        Debug.Log("Mouse in player trigger");
    }
}
