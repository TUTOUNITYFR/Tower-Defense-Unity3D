using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public Text roundsText;

	void OnEnable () {
        roundsText.text = PlayerStats.rounds.ToString();
	}

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void Menu()
    {
        Debug.Log("Direction le menu principal");
    }
	
}
