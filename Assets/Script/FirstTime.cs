using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Bolt;

public class FirstTime : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool p;
    void Awake()
    {
        if (PlayerPrefs.HasKey("primera"))
        {
            SceneManager.LoadScene("Login");
            
        }
    }

}

