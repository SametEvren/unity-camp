using System;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public List<string> names = new();
    public List<string> namesCopy = new();

    private void Start()
    {
        names.Add("Samet");
        names.Add("Berkan");
        names.Add("Caner");
        names.Add("Muaz");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            names.Add("Yusuf");
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            names.Insert(1,"Eren");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            names.Remove("Eren");
        }
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            names.RemoveAt(names.Count - 1);
        }
        
        if (Input.GetKeyDown(KeyCode.O))
        {
            namesCopy = new List<string>(names);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            namesCopy.Clear();
        }
    }
}
