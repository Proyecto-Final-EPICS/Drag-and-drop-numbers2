using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Bolt;

public class FirstTime : MonoBehaviour
{
    public static bool p;

    // Put the user in the login scene if its not the first time in the app
    void Awake()
    {
        if (PlayerPrefs.HasKey("primera"))
        {
            SceneManager.LoadScene("Login");
            
        }
    }

}

