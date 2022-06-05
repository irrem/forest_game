using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hey started");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("hey updated");
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //Vector3 force = new Vector3(horizontal, 0, vertical);
        //rb.AddForce(force * speed);
        
        //horizontal movement (x,z coordinates)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(2 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-2 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate( 0, 0, 2 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, -2 * Time.deltaTime);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Animal")
        {
            Debug.Log("carpisma");

        }
        else if (collision.gameObject.name == "Obstacle")
        {
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Animal")
        {
            Debug.Log("carpisma");

        }
        else if (other.gameObject.name == "Obstacle")
        {
        }
    }
}
