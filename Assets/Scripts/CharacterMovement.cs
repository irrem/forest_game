using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed ;
    public TextMeshProUGUI _scoreTxt;
    public float levelScore;
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate( 0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate( -speed * Time.deltaTime,0, 0);
        }

    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(collision.gameObject.name);
    //    if (collision.gameObject.name == "Animal")
    //    {
    //        Debug.Log("carpisma");

    //    }
    //    else if (collision.gameObject.name == "Obstacle")
    //    {
    //    }
    //}
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Animal")
        {
            Debug.Log("carpisma");
            _scoreTxt = GameObject.Find("Canvas/txtScore").GetComponent<TextMeshProUGUI>();
            levelScore = float.Parse(_scoreTxt.text, CultureInfo.InvariantCulture.NumberFormat);
            Debug.Log(levelScore);
            _scoreTxt.text = levelScore.ToString();
            Debug.Log("carpisma");

        }
        else if (other.gameObject.name == "Obstacle")
        {
            Debug.Log("carpisma");
            _scoreTxt = GameObject.Find("Canvas/txtScore").GetComponent<TextMeshProUGUI>();
            levelScore = float.Parse(_scoreTxt.text, CultureInfo.InvariantCulture.NumberFormat);
            Debug.Log(levelScore);
            _scoreTxt.text = levelScore.ToString();
            Debug.Log("carpisma");
        }
        else
        {
            Debug.Log("what is this");
        }
    }
}
