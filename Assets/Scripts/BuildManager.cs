using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public GameObject buildEffect;


    private void Awake() 
    {
        if(instance != null)
        {
            Debug.LogError("More Than One Buildmanager in Scene!");
            return;
        }
        instance = this;    
    }

    private TurretBlueprint turretToBuild;

    
    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.money >= turretToBuild.cost; } }

    public void BuildTurretOn(Node node)
    {
        if (PlayerStats.money < turretToBuild.cost)
        {
            Debug.Log("You are POOR");
            return;
        }

        PlayerStats.money -= turretToBuild.cost;

        GameObject turret = (GameObject) Instantiate(turretToBuild.prefab,node.GetBuildPosition(),Quaternion.identity);
        node.turret=turret;

        GameObject effect = (GameObject)Instantiate(buildEffect,node.GetBuildPosition(),Quaternion.identity);
        Destroy(effect,5f);
        Debug.Log("Turret Build! Money Left: " + PlayerStats.money);
    }


    public void selectTurrerTobuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
