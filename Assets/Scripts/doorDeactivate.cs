using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorDeactivate : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float maxDist;
    private bool playerHaveKey = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    void checkPlayerHaveKey() {
        playerHaveKey = player.GetComponent<Inventory>().getNumKeys() > 0;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, this.gameObject.transform.position);
        if (dist < maxDist) {
            if (Input.GetMouseButtonDown(0))
            {
                checkPlayerHaveKey();
                if (playerHaveKey) {
                    Destroy(this.gameObject);
                    // player.GetComponent<Inventory>().keysDecrease();
                }
            }
        }
    }
}