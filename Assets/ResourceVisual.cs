using UnityEngine;
using TMPro;


public class ResourceVisual : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private Resource Resource;

    private void Awake()
    {
        ResourceBank.GetResource(Resource)._numberChange += UpdateText;
    }

    public void UpdateText(int number)
    {
        Text.text = number.ToString();
    }
}
