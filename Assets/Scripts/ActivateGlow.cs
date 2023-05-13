using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGlow : MonoBehaviour
{
    [SerializeField]
    private Material plainMat;
    [SerializeField]
    private Material pulseMat;
    [SerializeField]
    private Material glowMat;
    [SerializeField]
    private float outlineThickness;
    [SerializeField]
    private Color outlineColor;
    [SerializeField]
    private float glowIntensity;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float maxDist;
    private float pulseMultiplier = 0;
    private bool isHovering;
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist < maxDist)
        {
            Debug.Log("Near bone");
            if (!isHovering)
            {
                this.gameObject.GetComponent<SpriteRenderer>().material = pulseMat;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().material = glowMat;
            }
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().material = plainMat;
        }

    }

    void OnMouseEnter()
    {
        //this.activateGlow();
        // player.GetComponent<Inventory>().SelectObject(this.gameObject);
        isHovering = true;
    }

    void OnMouseExit()
    {
        //this.deactivateGlow();
        // player.GetComponent<Inventory>().UnSelectObject();
        isHovering = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
