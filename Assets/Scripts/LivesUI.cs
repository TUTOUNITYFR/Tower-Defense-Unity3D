using UnityEngine.UI;
using UnityEngine;

public class LivesUI : MonoBehaviour {

    public Text livesText;

	void Update () {
        livesText.text = PlayerStats.lives + " LIVES";
	}
}
