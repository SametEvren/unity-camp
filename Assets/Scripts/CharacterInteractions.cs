using System;
using UnityEngine;

public class CharacterInteractions : MonoBehaviour
{
    public UIController uiController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gold"))
        {
            // print("You are in a gold");
            uiController.totalGold++;
            uiController.goldHolder.text = "Gold: " + uiController.totalGold;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Diamond"))
        {
            uiController.totalDiamond++;
            uiController.diamondHolder.text = "Diamond: " + uiController.totalDiamond;
            Destroy(other.gameObject);
        }
    }

    // private void OnTriggerStay(Collider other)
    // {
    //     print("You are staying in a gold");
    // }
    //
    // private void OnTriggerExit(Collider other)
    // {
    //     print("You left the gold");
    // }
}
