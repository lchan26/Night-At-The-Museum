using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
    [SerializeField] private List<Vector2> segment;
    [SerializeField] private float moveSpeed;
    private int currSegment = 0;
    private float timeLeft = 0;
    bool quit = false;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = segment[currSegment].magnitude / moveSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!quit)
        {
            if (timeLeft > 0)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = segment[currSegment].normalized * moveSpeed;
                timeLeft -= Time.deltaTime;
            }
            else if (currSegment < segment.Count - 1)
            {
                currSegment++;
                timeLeft = segment[currSegment].magnitude / moveSpeed;
            }
            else
            {
                quit = true;
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }
    }
}
