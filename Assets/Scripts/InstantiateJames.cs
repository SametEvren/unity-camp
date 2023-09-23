using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class InstantiateJames : MonoBehaviour
{
    public List<GameObject> allJames;
    public GameObject jamesPrefab;
    public GameObject jamesHolder;

    private void Start()
    {
        InvokeRepeating(nameof(InstantiateJamesGameObject), 3f, 1f);
    }

    private void InstantiateJamesGameObject()
    {
        var x = Random.Range(-5f, +5f);
        var y = Random.Range(1f, +5f);
        var z = Random.Range(-5f, +5f);
        var rot = Random.Range(-45f, 45f);
        
        GameObject newJames = Instantiate(jamesPrefab, new Vector3(x, y, z), Quaternion.identity,jamesHolder.transform);
        newJames.transform.rotation = Quaternion.Euler(new Vector3(0,rot,0));
        allJames.Add(newJames);
    }
}
