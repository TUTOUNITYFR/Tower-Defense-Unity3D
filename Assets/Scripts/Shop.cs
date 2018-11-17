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
}
