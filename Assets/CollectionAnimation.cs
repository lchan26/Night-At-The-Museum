using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionAnimation : MonoBehaviour
{
    [SerializeField]
    private GameObject collectionBone;
    [SerializeField]
    private Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            GameObject boneCopy = Instantiate(collectionBone, canvas.transform);
            boneCopy.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            boneCopy.GetComponent<CollectionBone>().SetTargetPos(this.gameObject.GetComponent<RectTransform>().localPosition);
            boneCopy.GetComponent<CollectionBone>().SetParticleSystem(this.gameObject.GetComponent<ParticleSystem>());
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            emitParticles();
        }
    }

    public void emitParticles()
    {
        this.gameObject.GetComponent<ParticleSystem>().Play();
    }
}
