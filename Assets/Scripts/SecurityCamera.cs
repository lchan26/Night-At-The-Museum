using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject securitycam;
    [SerializeField]
    private float offtime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(OffRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            player.transform.position = new Vector3(-10, -12, 0);
        }
    }

    IEnumerator OffRoutine()
    {
        while (true)
        {
            this.securitycam.GetComponent<Renderer>().enabled = true;
            this.securitycam.GetComponent<Collider2D>().enabled = true;
            yield return new WaitForSeconds(2f);
            this.securitycam.GetComponent<Renderer>().enabled = false;
            this.securitycam.GetComponent<Collider2D>().enabled = false;
            yield return new WaitForSeconds(2f);
        }
    }
}
