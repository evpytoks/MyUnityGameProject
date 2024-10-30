using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProductionBuilding : MonoBehaviour
{
    [SerializeField] private Resource Resource;
    [SerializeField] private Resource Level;
    [SerializeField] private float ProdTime;
    [SerializeField] private Slider Slider;
    
    private float _currentTime;
    private float _productionTime;
    
    public void AddResource()
    {
        StartCoroutine(AddResourceCoroutine());
    }
    
    public IEnumerator AddResourceCoroutine()
    {
        _productionTime = ProdTime * (1 - ResourceBank.GetResource(Level).Number * 0.01f);

        while (_currentTime < _productionTime)
        {
            _currentTime += Time.deltaTime;
            Slider.value = _currentTime / _productionTime;
            yield return null;
        }

        ResourceBank.ChangeResource(Resource, 1);
        _currentTime = 0;
        Slider.value = 0;
    }
}