using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSortingLayer : MonoBehaviour
{
    private string defaultSortingLayer;
    private int defaultSortingOrder;
    // Start is called before the first frame update
    void Start()
    {
        defaultSortingLayer = this.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
        defaultSortingOrder = this.gameObject.GetComponent<SpriteRenderer>().sortingOrder;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground2";
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = defaultSortingLayer;
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = defaultSortingOrder;
        }
    }
}
