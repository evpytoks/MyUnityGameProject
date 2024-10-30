using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private Resource Resource;
    
    public void MakeUpgrate()
    {
        ResourceBank.ChangeResource(Resource, 1);
    }
}
