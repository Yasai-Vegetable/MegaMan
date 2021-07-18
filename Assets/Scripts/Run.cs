using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right")) {
            rigidbody.MovePosition(transform.position + new Vector3(2, 0, 0) * Time.deltaTime);
            transform.LookAt(new Vector3(180, 0, 0));
            animator.SetBool("is_running", true);
        } else if(Input.GetKey("left")) {
            rigidbody.MovePosition(transform.position + new Vector3(-2, 0, 0) * Time.deltaTime);
            transform.LookAt(new Vector3(-180, 0, 0));
            animator.SetBool("is_running", true);
        } else {
            animator.SetBool("is_running", false);
        }

        Debug.Log(transform.position);
    }
}
