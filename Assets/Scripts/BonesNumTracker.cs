using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BonesNumTracker : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI score;

    //public int boneCount;

    void Update()
    {
     this.score.text = "Final Score: " + (Inventory.bonesCounter).ToString();
    }
}
//so if you want to read the current boneNum: BonesNumTracker.bones.boneCount

