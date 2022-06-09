using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip sound;
    AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            aSource.Pause();

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            aSource.Play();

        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            aSource.PlayOneShot(sound, .7f);

        }
    }
}
