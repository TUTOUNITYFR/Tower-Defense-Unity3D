using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public Text roundsText;

    public SceneFader sceneFader;

    public string menuSceneName = "MainMenu";

	void OnEnable () {
        roundsText.text = PlayerStats.rounds.ToString();
	}

    public void Retry()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }
    
    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }
	
}
