using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject timeBar;
    public GameObject obstacle;
    public GameObject fire;
    [SerializeField] ParticleSystem collectParticle = null;
    public float time;
    void Start()
    {
      //  fire.GetComponent<ParticleSystem>().enableEmission = true;
        time = 100;
    }
    void obstacle_control()
    {
        float rand = Random.Range(-5.0f, 12.0f);
        Instantiate(obstacle, new Vector3(-8, 0.8f, rand), Quaternion.identity);
        Vector3 position = obstacle.transform.position;
        position.z += 0.05f;
        if (position.z >= 5.0f)
        {
            Destroy(obstacle);
        }

    }
    void Update()
    {
        obstacle_life();
    }
    void obstacle_life()
    {
        time -= 0.1f;
        if (time / 100 <= 0)
        {//fired
           // time = 0;
            collectParticle.Play();
            
            float rand = Random.Range(-5.0f, 2.0f);
            obstacle.transform.position = new Vector3(rand, 1.47f, rand);
            time = 100;
        }
        timeBar.transform.localScale = new Vector3(time / 100, 1, 1);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // Debug.Log(time);
            collectParticle.Stop();
            float rand = Random.Range(-5.0f, 2.0f);
            obstacle.transform.position = new Vector3(rand, 1.47f, rand);
            time = 100;

        }
    }
}
