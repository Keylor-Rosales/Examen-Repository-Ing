using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;
	public float restartDelay = 1f;
	public GameObject CompleteLevelUI;
	public GameObject DesactiveUI;
	public int nextSceneLoad;

	void Start()
	{
		nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
	}

	public void CompleteLevel()
	{
		CompleteLevelUI.SetActive(true);
		DesactiveUI.SetActive(false);
	}

	public void EndGame()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Invoke("Restart", restartDelay);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}