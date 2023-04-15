using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityGuardController : MonoBehaviour
{

    private int currentDir = 0;

    private Vector3 prevPos;
    private Vector3 currPos;
    // Start is called before the first frame update
    void Start()
    {
        currPos = transform.position;
        prevPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currPos = transform.position;
        List<float> dotProducts = new List<float>();
        // Index 0 is up, 1 is down, 2 is right, 3 is left
        Vector3 direction = (currPos - prevPos).normalized;
        Vector3 zeroVector = new Vector3(0, 0, 0);

        if (direction != zeroVector) {
            dotProducts.Add(Vector3.Dot(direction, Vector2.up));
            dotProducts.Add(Vector3.Dot(direction, Vector2.down));
            dotProducts.Add(Vector3.Dot(direction, Vector2.right));
            dotProducts.Add(Vector3.Dot(direction, Vector2.left));

            float max_dist = Mathf.NegativeInfinity;
            for (int i = 0; i < 4; i++) {
                if (dotProducts[i] > max_dist) {
                    max_dist = dotProducts[i];
                    currentDir = i;
                }
            }

            Vector3 rotationVector = new Vector3(0, 0, 0);

            // // If attached to flashlight
            // if (currentDir == 0) {
            //     rotationVector.z = 180;
            //     transform.rotation = Quaternion.Euler(rotationVector);
            // }
            // else if (currentDir == 1) {
            //     rotationVector.z = 0;
            //     transform.rotation = Quaternion.Euler(rotationVector);
            // }
            // else if (currentDir == 2) {
            //     rotationVector.z = 90;
            //     transform.rotation = Quaternion.Euler(rotationVector);
            // }
            // else if (currentDir == 3) {
            //     rotationVector.z = 270;
            //     transform.rotation = Quaternion.Euler(rotationVector);
            // }

            // If attached to security guard
            if (currentDir == 0) {
                rotationVector.z = 0;
                transform.rotation = Quaternion.Euler(rotationVector);
            }
            else if (currentDir == 1) {
                rotationVector.z = 180;
                transform.rotation = Quaternion.Euler(rotationVector);
            }
            else if (currentDir == 2) {
                rotationVector.z = 270;
                transform.rotation = Quaternion.Euler(rotationVector);
            }
            else if (currentDir == 3) {
                rotationVector.z = 90;
                transform.rotation = Quaternion.Euler(rotationVector);
            }
            prevPos = transform.position;
        }
    }
}
