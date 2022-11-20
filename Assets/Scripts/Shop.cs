using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standredTurrent;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;
    BuildManager buildManager;

    private void Start() {
        buildManager = BuildManager.instance;
    }
    public void selectStandardTurret()
    {
        Debug.Log("Standred Turret");
        buildManager.selectTurrerTobuild(standredTurrent);
    }

    public void selectMissileLauncher()
    {
        Debug.Log("Missile Launcher");
        buildManager.selectTurrerTobuild(missileLauncher);
    }

    public void selectLaserBeamer()
    {
        Debug.Log("Laser Beamer");
        buildManager.selectTurrerTobuild(laserBeamer);
    }

    // public void purchaseStandardTurret()
    // {
    //     Debug.Log("Standred Turret");
    // }
}
