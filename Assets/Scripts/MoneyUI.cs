using UnityEngine.UI;
using UnityEngine;

public class MoneyUI : MonoBehaviour {

    public Text moneyText;

	void Update () {
        moneyText.text = "$" + PlayerStats.money;
	}
}
