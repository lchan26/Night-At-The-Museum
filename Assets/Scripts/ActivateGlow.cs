using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGlow : MonoBehaviour
{
    [SerializeField]
    private Material mat;
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

    private void activateGlow()
    {
        Debug.Log("Activate glow");
        mat.SetVector("_OutlineColor", outlineColor * glowIntensity * pulseMultiplier);
        mat.SetFloat("_OutlineThickness", outlineThickness);
    }

    private void deactivateGlow()
    {
        mat.SetVector("_OutlineColor", Vector4.zero);
        mat.SetFloat("_OutlineThickness", 0);
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
                pulseMultiplier = Mathf.Sin(Time.time * speed) * 0.5f + 0.5f;
            }
            else
            {
                pulseMultiplier = 1;
            }
            this.activateGlow();
        }
        else
        {
            this.deactivateGlow();
        }

    }

    void OnMouseEnter()
    {
        //this.activateGlow();
        player.GetComponent<Inventory>().SelectObject(this.gameObject);
        isHovering = true;
    }

    void OnMouseExit()
    {
        //this.deactivateGlow();
        player.GetComponent<Inventory>().UnSelectObject();
        isHovering = false;
    }
}
