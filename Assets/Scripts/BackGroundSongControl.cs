using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSongControl : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip backgroundsong;
    AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            aSource.Pause();

        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            aSource.Play();

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            aSource.PlayOneShot(backgroundsong, .7f);

        }
    }
}




