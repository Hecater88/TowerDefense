using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint anotherTurret;
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        buildManager.SetTurretToBuild(standardTurret);
    }

    public void SelectAnotherTurret()
    {
        buildManager.SetTurretToBuild(anotherTurret);

    }
}
