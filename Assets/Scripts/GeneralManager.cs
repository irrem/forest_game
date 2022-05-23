using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralManager : MonoBehaviour
{
    public GameObject people;
    public bool is_people=false;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("people_coming", 0.0f, 1.0f);
        Invoke("people_coming", 2.0f);

        
    }
    void people_coming()
    {
        float rand = Random.Range(-5.0f, 12.0f);
        GameObject new_people = Instantiate(people, new Vector3(-8, 0.8f, rand),Quaternion.identity);
        Debug.Log("people is coming");
        is_people = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (is_people)
        {
            Vector3 position = people.transform.position;
            position.z += 0.05f;
            if (position.z >= 5.0f)
            {
                Destroy(people);
            }
            people.transform.position = position;
           


        }
    }
}
