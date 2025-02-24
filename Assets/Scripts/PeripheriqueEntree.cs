using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GestionnairePeriferique : MonoBehaviour
{

    [SerializeField] private float vitesseDeplacement;
    private Rigidbody _rb;
    Vector2 directionMouvement;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void OnDeplacement(InputValue valeur)
    {
        directionMouvement = valeur.Get<Vector2>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 directionSurPlane = new Vector3(directionMouvement.x, 0, directionMouvement.y);
        _rb.AddForce(directionSurPlane, ForceMode.VelocityChange);

    }
}
