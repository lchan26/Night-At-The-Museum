using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBoneInitOr : MonoBehaviour
{

    public GameObject bonesPrefab;
    public GameObject square1;
    public GameObject square2; 

    // Start is called before the first frame update
    public void Start()
    {
        if (Random.Range(1, 3) == 1)
        {
            float positionx = square1.transform.position.x;
            float positiony = square1.transform.position.y;
            float positionScaleX = square1.transform.localScale.x;
            float positionScaleY = square1.transform.localScale.y;
            Vector2 randomSpawnPosition = new Vector2(Random.Range(positionx + (positionScaleX / 2), positionx - (positionScaleX / 2)), Random.Range(positiony + (positionScaleY / 2), positiony - (positionScaleY / 2)));
            Instantiate(bonesPrefab, randomSpawnPosition, Quaternion.identity);
        }
        else
        {
            float positionx = square2.transform.position.x;
            float positiony = square2.transform.position.y;
            float positionScaleX = square2.transform.localScale.x;
            float positionScaleY = square2.transform.localScale.y;
            Vector2 randomSpawnPosition = new Vector2(Random.Range(positionx + (positionScaleX / 2), positionx - (positionScaleX / 2)), Random.Range(positiony + (positionScaleY / 2), positiony - (positionScaleY / 2)));
            Instantiate(bonesPrefab, randomSpawnPosition, Quaternion.identity);
        }
       

    }
} 


  
