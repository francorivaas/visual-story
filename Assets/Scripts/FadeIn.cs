using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetTrigger("FadeIn");
        Destroy(gameObject, 3.6f);
    }
}
