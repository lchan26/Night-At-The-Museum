using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class InfoCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private TextMeshProUGUI info;
    [SerializeField]
    private float maxDist;

    private RectTransform rectTransform;
    private Vector2 uiOffset;
    // Start is called before the first frame update
    void Start()
    {
        // // Get the rect transform
        this.rectTransform = GetComponent<RectTransform>();
 
        //  // Calculate the screen offset
        //  this.uiOffset = new Vector2((float)Canvas.sizeDelta.x / 2f, (float)Canvas.sizeDelta.y / 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 transformPosition = new Vector3(-30,0,0);
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transformPosition);
        Vector3 localPosition = new Vector3(screenPos.x, Screen.height - screenPos.y, screenPos.z);
        float dist = Vector3.Distance(player.transform.position, localPosition);
        this.gameObject.GetComponent<TextMeshProUGUI>().text = dist.ToString();
        // if (dist < maxDist && dist > -maxDist) {
        // // this.gameObject.GetComponent<TextMeshProUGUI>().text = dist.ToString();
        // // if (dist > 10000) {
        //     this.gameObject.GetComponent<TextMeshProUGUI>().text = "Number of bones: " + player.GetComponent<Inventory>().getNumBones().ToString() + "/5";
        //     // this.gameObject.GetComponent<TextMeshProUGUI>().text = "Number of bones: " + player.GetComponent<Inventory>().getNumBones().ToString() + "/5";
        // } else {
        //     this.gameObject.GetComponent<TextMeshProUGUI>().text = dist.ToString();
        // }
    }
}
