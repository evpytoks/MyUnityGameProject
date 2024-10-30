using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public static class ResourceBank
{
    private static Dictionary<Resource, ObservableInt> _gameResource = new();
    
    public static void ChangeResource(Resource r, int v) {
        if (_gameResource.ContainsKey(r)) {
            _gameResource[r].Number += v;
        } else {
            _gameResource.Add(r, new ObservableInt(v));
        }
    }

    public static ObservableInt GetResource(Resource r) {
        if (_gameResource.ContainsKey(r)) {
            return _gameResource[r];
        }
        ChangeResource(r, 0);
        return _gameResource[r];
    }
}
