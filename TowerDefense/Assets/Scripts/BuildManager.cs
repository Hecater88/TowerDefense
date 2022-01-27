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

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

}
