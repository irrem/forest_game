using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoRegister()
    {
        SceneManager.LoadScene("RegisterScene");
    }
    public void GoLogin()
    {
        SceneManager.LoadScene("LoginScene");
    }
}
