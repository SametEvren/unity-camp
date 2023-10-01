using System;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    private int[] numberArray = new int[4];

    private string[] names = {"Samet", "Caner", "Berkan", "Muaz"};

    [SerializeField] private GameObject[] players;

    private void Start()
    {
        numberArray[0] = 3;
        numberArray[1] = 5;
        numberArray[2] = 7;
        numberArray[3] = 9;
        
        // Debug.Log(numberArray[2]);
        // Debug.Log(names[3]);

        players = GameObject.FindGameObjectsWithTag("RedTeam");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            players = GameObject.FindGameObjectsWithTag("BlueTeam");
        }
    }
}
