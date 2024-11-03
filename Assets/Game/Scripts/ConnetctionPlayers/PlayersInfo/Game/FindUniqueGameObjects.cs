using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FindUniqueGameObjects : MonoBehaviour
{
    private Dictionary<string, List<GameObject>> _cachedObjects = new Dictionary<string, List<GameObject>>();

    public List<GameObject> FindObjectWithTag(string tag)
    {
        if (_cachedObjects.ContainsKey(tag))
        {
            return _cachedObjects[tag];
        }

        List<GameObject> foundObjects = FindObjectsOfType<GameObject>()
            .Where(element => element.CompareTag(tag))
            .ToList();
        _cachedObjects[tag] = foundObjects;

        return foundObjects;
    }
}
