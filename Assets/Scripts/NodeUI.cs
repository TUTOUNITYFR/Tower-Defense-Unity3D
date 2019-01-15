using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour {

    public GameObject ui;
    private Node target;

    public Text sellAmount;

    public Text upgradeCost;
    public Button upgradeButton;

	public void SetTarget (Node _target)
    {
        target = _target;
        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            upgradeCost.text = "-" + target.turretBlueprint.upgradeCost + "$";
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeCost.text = "<i>DONE</i>";
            upgradeButton.interactable = false;
        }

        sellAmount.text = "+" + target.turretBlueprint.GetSellAmount() + "$";

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }
    
    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }
}
