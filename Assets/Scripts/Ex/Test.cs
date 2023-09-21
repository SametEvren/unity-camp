using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private bool a;
    [SerializeField] private bool b;
    private void Start()
    {
        if (a || b)
        {
            Debug.Log("En azından ikisinden biri doğrudur");
        }
        else
        {
            Debug.Log("İkisi birden yanlıştır");
        }
    }
}
