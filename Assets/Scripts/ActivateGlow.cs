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
        mat.SetVector("_OutlineColor", outlineColor * glowIntensity);
        mat.SetFloat("_OutlineThickness", outlineThickness);

        player.GetComponent<Inventory>().SelectObject(this.gameObject);
    }

    void OnMouseExit()
    {
        mat.SetVector("_OutlineColor", Vector4.zero);
        mat.SetFloat("_OutlineThickness", 0);
        player.GetComponent<Inventory>().UnSelectObject();
    }
}
