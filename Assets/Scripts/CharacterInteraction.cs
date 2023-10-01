using UnityEngine;
using System;

public class CharacterInteraction : MonoBehaviour
{
    public int health;
    public event Action OnPlayerDeath;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            if (health <= 0)
                return;
            
            health -= 10;

            if (health <= 0)
            {
                if (OnPlayerDeath != null)
                    OnPlayerDeath();
            }
            // var  = Instantiate(ParticleManager.Instance.hitParticle, other.transform.position, Quaternion.identity);
            // Destroy(hitParticle,1);
        }
    }
}
