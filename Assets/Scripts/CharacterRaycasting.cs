using System;
using UnityEngine;

public class CharacterRaycasting : MonoBehaviour
{
    public LayerMask layerMask;
    private void Update()
    {
        if(Physics.Raycast(transform.position  + Vector3.up, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 20f, layerMask, QueryTriggerInteraction.Ignore))
        {
            print("Temas");
            
            Debug.DrawRay(transform.position + Vector3.up, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.red);
        }
        else
        {
            print("Temas yok");
            
            Debug.DrawRay(transform.position  + Vector3.up, transform.TransformDirection(Vector3.forward) * 20f, Color.blue);
        }
    }
}
