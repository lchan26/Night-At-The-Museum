using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private GameObject selectedObject;

    private int numBones;

    [SerializeField] private float maxDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(selectedObject != null)
            {
                numBones++;
                Destroy(selectedObject);
                selectedObject = null;
            }
        }
    }

    public void SelectObject(GameObject newObject)
    {
        selectedObject = newObject;
    }

    public void UnSelectObject()
    {
        selectedObject = null;
    }
}
