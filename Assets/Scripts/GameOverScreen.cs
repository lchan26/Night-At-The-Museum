using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
	
	public void Setup()
	{
        SceneManager.LoadScene("EndScene");
    }
}

