using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{

    [SerializeField]
    private float rotationspeed;
    private bool movingright = true;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movingright)
        {
            transform.Rotate(0, 0, rotationspeed);
            if (transform.eulerAngles.z < 200 && transform.eulerAngles.z > 65)
            {
                movingright = false;
            }
        }

        else if (!movingright)
        {
            transform.Rotate(0, 0, -rotationspeed);
            if (transform.eulerAngles.z > 70 && transform.eulerAngles.z < 295)
            {
                movingright = true;
            }
        }

    }

}
