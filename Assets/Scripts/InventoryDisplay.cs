using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class InventoryDisplay : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private TextMeshProUGUI bones;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.bones.text = player.GetComponent<Inventory>().getNumBones().ToString();
        if (player.GetComponent<Inventory>().getNumBones() == 1)
        {
            SceneManager.LoadScene("EndScene");
        }
    }



    
}


