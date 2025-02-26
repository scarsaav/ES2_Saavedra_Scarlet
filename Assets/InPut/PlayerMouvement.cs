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



    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        _moveDirection = move.action.ReadValue<Vector3>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(_moveDirection.x * moveSpeed,  _moveDirection.y * moveSpeed, _moveDirection.z * moveSpeed);
        
    }

    //void OnVitesse(InputValue bouton)
    //{
    //    Debug.Log("ativé" + bouton.isPressed);
    //}
}
