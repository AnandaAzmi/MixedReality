using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;

    public void PlayRunAnimation()
    {
        animator.Play("Run");
    }

    public void PlayAttackAnimation()
    {
        animator.Play("Attack2");
    }

    public void PlayDyingAnimation()
    {
        animator.Play("Dying");
    }
}
