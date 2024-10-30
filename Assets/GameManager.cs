using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        ResourceBank.ChangeResource(Resource.Humans, 10);
        ResourceBank.ChangeResource(Resource.Food, 5);
        ResourceBank.ChangeResource(Resource.Wood, 5);
    }
}

