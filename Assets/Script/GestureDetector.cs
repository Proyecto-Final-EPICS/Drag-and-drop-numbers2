using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestureDetector : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                if (Input.GetTouch(i).tapCount == 2)
                {
                    
                }
            }
        }
    }
}
