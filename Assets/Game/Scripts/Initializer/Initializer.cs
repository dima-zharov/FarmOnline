using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    private List<IInitializer> _objectsToInitialize;

    public void InitializeObjects()
    {
        FindNeedObjects();

        foreach (var @object in _objectsToInitialize)
            @object.Initialize();
        
    }

    private void FindNeedObjects()
    {
        _objectsToInitialize = FindObjectsOfType<MonoBehaviour>()
            .OfType<IInitializer>().ToList();
    }
}
