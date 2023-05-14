using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private GameObject selectedObject;
    private GameObject selectedKey;
    private int numBones;
    private int numKeys;

    public static int bonesCounter;

    [SerializeField] private float maxDistance;

    // Start is called before the first frame update
    void Start()
    {
        ScoreTracker.score = 0;
    }

    public int getNumBones()
    {
        return numBones;
    }
    public int getNumKeys()
    {
        return numKeys;
    }
    // public void keysDecrease()
    // {
    //     if(numKeys > 0)
    //     {
    //         numKeys --;
    //     }
    // }

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
                    bonesCounter++;
                    Destroy(selectedObject);
                    selectedObject = null;
                }
            }

            if(selectedKey != null)
            {
                float dist = Vector3.Distance(selectedKey.transform.position, transform.position);
                //checking if the distance between player and object isn't too far
                if(dist < maxDistance)
                {
                    numKeys++;
                    Destroy(selectedKey);
                    selectedKey = null;
                }
            }
        }
    }

    public bool PickUpBone(Vector2 boneLocation)
    {
        Vector2 playerPos = new Vector2(transform.position.x, transform.position.y);
        if (Vector2.Distance(boneLocation, playerPos) < maxDistance){
            numBones++;
            ScoreTracker.score = ScoreTracker.score + 1;
            Debug.Log(ScoreTracker.score);
            return true;
        }
        return false;
    }

    public bool PickUpKey(Vector2 keyLocation)
    {
        Vector2 playerPos = new Vector2(transform.position.x, transform.position.y);
        if (Vector2.Distance(keyLocation, playerPos) < maxDistance)
        {
            numKeys++;
            return true;
        }
        return false;
    }

    public void SelectObject(GameObject newObject)
    {
        selectedObject = newObject;
    }

    public void UnSelectObject()
    {
        selectedObject = null;
    }

    public void SelectKey(GameObject newObject)
    {
        selectedKey = newObject;
    }

    public void UnSelectKey()
    {
        selectedKey = null;
    }

    void Awake()
    {  
        bonesCounter = numBones; //don't think this actually works lmao
        
    }

}
