using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkandJump : MonoBehaviour
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
        
    }
    private void FixedUpdate(){
        if(Input.GetKey(KeyCode.W)){
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0,0,2f)*Time.deltaTime);
        }
        else{
            animator.SetBool("isWalking", false);
        }
        if(Input.GetKey(KeyCode.Space)){
            animator.SetBool("isJumping", true);
            transform.Translate(new Vector3(0,0,2f)*Time.deltaTime);
        }
        else{
            animator.SetBool("isJumping", false);
        }
    }
}
