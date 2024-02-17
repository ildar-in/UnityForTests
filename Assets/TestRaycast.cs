using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TestRaycast : MonoBehaviour
{
    public LayerMask LayerMask;
    void Update()
    {
        var hits = Physics.RaycastAll(Camera.main.transform.position, Camera.main.transform.forward, float.PositiveInfinity, LayerMask);
        var names = hits.Select(h => h.transform.name);
        var namesString = names.Count()+ ":"+ string.Join(",", names);
        Debug.Log(namesString);
    }
}
