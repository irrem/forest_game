using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hey started");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hey updated");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(horizontal, 0, vertical);
        rb.AddForce(force*speed);
        
    }
}
