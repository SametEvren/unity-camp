using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform player;
    public float speed;

    private void Update()
    {
        Vector3 distance = player.position - transform.position;
        Vector3 direction = distance.normalized;
        Vector3 velocity = direction * speed;

        Vector3 moveAmount = velocity * Time.deltaTime;

        float distanceToPlayer = distance.magnitude;

        if(distanceToPlayer > 2)
            transform.position += moveAmount;
    }
}
