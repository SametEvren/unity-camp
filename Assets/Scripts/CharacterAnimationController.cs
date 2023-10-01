using System;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    public Animator animator;
    private static readonly int Die = Animator.StringToHash("Die");
    public CharacterInteraction characterInteraction;

    private void Start()
    {
        characterInteraction = FindObjectOfType<CharacterInteraction>();
        characterInteraction.OnPlayerDeath += TriggerDieAnimation;
    }

    public void TriggerDieAnimation()
    {
        animator.SetTrigger(Die);
    }
}