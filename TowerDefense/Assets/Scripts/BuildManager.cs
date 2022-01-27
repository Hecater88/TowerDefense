using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    //Singleton
    void Awake()
    {
        if (instance != null)
            return;

        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;
    private TurretBlueprint turretToBuild;

    public bool CanBuild
    {
        get
        {
            return turretToBuild != null;
        }
    }
    public void BuildTurretOn(Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("No tienes dinero para eso pobre");
            return;
        }
        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.transform.position, Quaternion.identity);
        node.turret = turret;

        Debug.Log("Dinero que te queda: " + PlayerStats.Money);

    }
    public void SetTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

}
