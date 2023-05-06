using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour
{

    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("music");
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject); 
        }
        DontDestroyOnLoad(this.gameObject); 
    }

    void Update()
    {
         Scene currentScene = SceneManager.GetActiveScene();

         string currentSceneName = currentScene.name;

         if (currentSceneName == "Colliders") {
            Destroy(this.gameObject);
         }
    }
}
