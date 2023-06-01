using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
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
        if(animator != null)
        {
            if(Input.GetKeyDown(KeyCode.B))
            {
                animator.SetBool("death", true);
            } else if(Input.GetKeyUp(KeyCode.B))
            {
                animator.SetBool("death", false);
            }

            if(Input.GetMouseButtonDown(1))
            {
                animator.SetBool("Aim", true);
            } else if(Input.GetMouseButtonUp(1))
            {
                animator.SetBool("Aim", false);
            }
        }
    }
}
