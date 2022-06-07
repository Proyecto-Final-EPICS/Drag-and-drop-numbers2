using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpObject;
    public Animator animator;

    // Opens and closes the accesible menu
    public void PopUp()
    {
        if(popUpObject.activeSelf == false)
        {
            popUpObject.SetActive(true);
        }
        else{
            popUpObject.SetActive(false);
        }
        
    }
}
