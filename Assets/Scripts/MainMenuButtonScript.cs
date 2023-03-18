using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonScript : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Colliders");
    }

    public void GoToTutorial()
    {
        SceneManager.LoadScene("TutorialScreen");
    }
    public void GoToCredits()
    {
        SceneManager.LoadScene("CreditsScreen");
    }

}

