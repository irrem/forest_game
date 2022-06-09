using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManagement : MonoBehaviour
{
    public GameObject healthBar;
    public GameObject animal;
    public float health;
    public bool isHungry=true;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        if (isHungry)
        {
           // Debug.Log("hareket");
            InvokeRepeating("animal_life", 0.0f, 2.0f);
        }
        //Invoke("animal_movement", 2.0f);
        //m_animator = GetComponent<Animator>();
    }
    void animal_control()
    {
        float rand = Random.Range(-5.0f, 12.0f);
        Instantiate(animal, new Vector3(-8, 0.8f, rand), Quaternion.identity);
        Vector3 position = animal.transform.position;
        position.z += 0.05f;
        if (position.z >= 5.0f)
        {
            Destroy(animal);
        }
        //Debug.Log("people is coming");
      
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(health);
        animal_life();
    }
    void animal_life()
    {
        //Debug.Log("azaliyor");
        health -= 0.1f;
        if (health / 100 <= 0)
        {
           // Debug.Log("Its died!");
            health = 0;

            float rand = Random.Range(-5.0f, 2.0f);
            //Instantiate(animal, new Vector3(-4, 1f, rand),Quaternion.identity);

            //Vector3 position = animal.transform.position;
            //Debug.Log("post"+position);
            ////position.z += 0.05f;
            ////if (position.z >= 5.0f)
            ////{
            ////    Destroy(animal);
            //////}
            //position.z = 5;
            //position.x = 4;
            animal.transform.position = new Vector3(rand, 1.47f, rand);
            health = 100;
        }
        healthBar.transform.localScale = new Vector3(health / 100, 1, 1);      
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // Debug.Log(health);
            health = 100;
        }
    }
    
}
