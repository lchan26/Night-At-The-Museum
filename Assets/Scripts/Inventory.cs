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

    public int getNumBones()
    {
        return numBones;
    }

    // Update is called once per frame
    void Update()
    {
        //calculate distance between player and selected object
        if (Input.GetMouseButtonDown(0))
        {
            //making sure there's an actual object selected
            if(selectedObject != null)
            {
                float dist = Vector3.Distance(selectedObject.transform.position, transform.position);
                //checking if the distance between player and object isn't too far
                if(dist < maxDistance)
                {
                    numBones++;
                    Destroy(selectedObject);
                    selectedObject = null;
                }
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
