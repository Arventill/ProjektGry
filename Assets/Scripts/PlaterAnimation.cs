using UnityEngine;
using UnityEngine.UIElements;

public class PlaterAnimation : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {
            if (animator.GetBool("IsRunning") == false)
            {
                animator.gameObject.SetActive(false);
                animator.gameObject.SetActive(true);
                animator.Play("demo_combat_run", 0, 0f);
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsIdle", false);
                animator.SetBool("IsShooting", false);
            }
        }
        else if (Input.GetMouseButtonDown((int)MouseButton.LeftMouse))
        {
            if (animator.GetBool("IsShooting") == false)
            {
                animator.gameObject.SetActive(false);
                animator.gameObject.SetActive(true);
                animator.Play("demo_combat_shoot", 0, 0f);
                animator.SetBool("IsShooting", true);
                animator.SetBool("IsIdle", false);
                animator.SetBool("IsRunning", false);
            }
        }
        else
        {
            if (animator.GetBool("IsIdle") == false && animator.GetBool("IsShooting") == false)
            {
                animator.gameObject.SetActive(false);
                animator.gameObject.SetActive(true);
                animator.SetBool("IsIdle", true);
                animator.SetBool("IsRunning", false);
                animator.SetBool("IsShooting", false);
            }
            else if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                animator.gameObject.SetActive(false);
                animator.gameObject.SetActive(true);
                animator.SetBool("IsIdle", true);
                animator.SetBool("IsRunning", false);
                animator.SetBool("IsShooting", false);
            }

        }
        //animatorController.parameters.
    }
}
