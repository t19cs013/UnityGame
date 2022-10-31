using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    private bool isNear;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        isNear = false;
        animator = transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isNear){
            animator.SetBool("Open", !animator.GetBool("Open"));
        }
    }

    public void openReset(){
        animator.SetBool("Open", true);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            isNear = true;
        }   
    }
}
