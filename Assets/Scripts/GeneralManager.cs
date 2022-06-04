using UnityEngine;
public class GeneralManager : MonoBehaviour
{
    public GameObject people;
    public bool is_people=false;
    public GameObject levelBar;
    public int time;
    public float levelScore;

    // Start is called before the first frame update
    void Start()
    { 
        levelScore = 0;
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
        
        if (levelScore / 100 >= 1)
        {
            Debug.Log("Congragulations!");
        }
        else
        {
            levelScore += 0.1f;
            levelBar.transform.localScale = new Vector3(levelScore / 100, 1, 1);
        }
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
