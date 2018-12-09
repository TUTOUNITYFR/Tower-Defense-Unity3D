using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncherTurret;
    public TurretBlueprint laserBeamerTurret;

    private BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Tourelle standard selectionnée");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher()
    {
        Debug.Log("Lance missile selectionné");
        buildManager.SelectTurretToBuild(missileLauncherTurret);
    }

    public void SelectLaserBeamer()
    {
        Debug.Log("Laser beamer selectionné");
        buildManager.SelectTurretToBuild(laserBeamerTurret);
    }
}
