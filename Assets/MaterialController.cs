using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    [SerializeField]
    private Material mat;
    private float pulseMultiplier = 0;
    [SerializeField]
    private float outlineThickness;
    [SerializeField]
    private Color outlineColor;
    [SerializeField]
    private float glowIntensity;
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pulseMultiplier = Mathf.Sin(Time.time * speed) * 0.5f + 0.5f;

        mat.SetVector("_OutlineColor", outlineColor * glowIntensity * pulseMultiplier);
        mat.SetFloat("_OutlineThickness", outlineThickness);
    }
}
