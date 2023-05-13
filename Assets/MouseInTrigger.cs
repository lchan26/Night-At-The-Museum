using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInTrigger : MonoBehaviour
{
    private bool mouseNearby = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool MouseNearby()
    {
        return mouseNearby;
    }
    private void OnMouseEnter()
    {
        Debug.Log("Mouse Enter");
        mouseNearby = true;
    }
    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
        mouseNearby = false;
    }
}
