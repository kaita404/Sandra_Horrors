using UnityEngine;

public class RedLightAnimation : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TriggerRedLight()
    {
        animator.Play("RedGlowAnim");
    }
}