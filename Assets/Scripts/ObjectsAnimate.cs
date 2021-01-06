using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsAnimate : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.StartPlayback();
            //animator.gameObject.SetActive(true);
        }
    }
}
