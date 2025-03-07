using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMouvement : MonoBehaviour
{

    public Rigidbody rb;
    public float moveSpeed;
    private Vector3 _moveDirection;
    private Vector3 directionInput;

    public InputActionReference move;


    private Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        _moveDirection = move.action.ReadValue<Vector3>();
        

        if(_moveDirection != Vector3.zero)
        {
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }


        if(Input.GetKey("S"))
        {
            animator.SetBool("IsReculer", true);
        }
        else
        {
            animator.SetBool("IsReculer", false);
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(_moveDirection.x * moveSpeed,  _moveDirection.y * moveSpeed, _moveDirection.z * moveSpeed);
        
    }

    void OnVitesse(InputValue etatBouton)
    {
        if(etatBouton.isPressed)
        {
            moveSpeed = 20;
            animator.SetFloat("Speed", 2f);
        }
        else
        {
            moveSpeed = 5;
            animator.SetFloat("Speed", 1f);
        }
    }

    
}
