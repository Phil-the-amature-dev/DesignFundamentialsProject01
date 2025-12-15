using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class PuzzleDoorAnimationScript : MonoBehaviour
{
    public GameObject target;

    private Animator animator;
    private bool isPlaying = false;

    private int currentAnimationValidationId = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null)
        {
            target = gameObject;
        }
        animator = target.GetComponent<Animator>();
        if (animator)
        {
            animator.speed = 0f;
        }
    }

    public void Animate()
    {
        if (animator)
        {
            animator.speed = 1f;
            isPlaying = true;
            StartCoroutine(WaitForAnimationToEnd());
        }
    }

    float GetCurrentTime()
    {
        return animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }

    IEnumerator WaitForAnimationToEnd()
    {
        currentAnimationValidationId++;
        int validationId = currentAnimationValidationId;
        while (GetCurrentTime() >= 1.0f)
        {
            if (currentAnimationValidationId != validationId) break;
            yield return null;
        }
        while (GetCurrentTime() < 1.0f)
        {
            if (currentAnimationValidationId != validationId) break;
            yield return null;
        }
        isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
