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
        player = GameObject.Find("Abinger");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked Bone");
        if(player.GetComponent<Inventory>().PickUpBone(new Vector2(transform.position.x, transform.position.y)))
        {
            Destroy(this.gameObject);
        }
    }
}