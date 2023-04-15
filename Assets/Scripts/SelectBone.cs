using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBone : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        player.GetComponent<Inventory>().SelectObject(this.gameObject);
    }

    void OnMouseExit()
    {
        player.GetComponent<Inventory>().UnSelectObject();
    }
}