using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FinalScoreDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //this.score.text = "Final Score: " + (BonesNumTracker.bones.boneCount * 100).ToString();
    }
}
