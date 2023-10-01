using UnityEngine;
using UnityEngine.AI;

public class MichelleAIController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera mainCamera;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray movePosition = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(movePosition, out var hitInfo))
            {
                agent.SetDestination(hitInfo.point);
            }
        }
            
    }
}
