using System;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    #region Singleton

    public static ParticleManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    #endregion

    public CharacterInteraction characterInteraction;
    //public GameObject hitParticle;
    public GameObject dieParticle;

    private void Start()
    {
        characterInteraction = FindObjectOfType<CharacterInteraction>();
        characterInteraction.OnPlayerDeath += CreateDieParticle;
    }

    public void CreateDieParticle()
    {
        print("Created Die Particle");
        //Create Die Particle
    }
}
