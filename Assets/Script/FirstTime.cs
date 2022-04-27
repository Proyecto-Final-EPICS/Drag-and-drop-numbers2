using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if (!PlayerPrefs.HasKey("primera"))
        {
            PlayerPrefs.SetString("primera", ".");
        }
        else
        {
            SceneManager.LoadScene("Main");
        }
        
    }

}
