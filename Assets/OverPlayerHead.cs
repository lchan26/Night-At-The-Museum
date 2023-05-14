using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverPlayerHead : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(playerTransform.position);
        // add a tiny bit of height?
        screenPos.x += 2; // adjust as you see fit.
        this.gameObject.GetComponent<RectTransform>().position = screenPos;
        //this.transform.position = screenPos;
    }
}
