using UnityEngine;

public class Shop : MonoBehaviour {

    private BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("Tourelle standard selectionnée");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseMissileLauncher()
    {
        Debug.Log("Lance missile selectionné");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);
    }
}
