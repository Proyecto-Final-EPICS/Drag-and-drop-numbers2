using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accesibilty : MonoBehaviour
{
    public static bool UAP_sw;
    public static bool sw_read = false;
    public GameObject popUpObject;

    // changes the accesible mode boolean controler
    public void activar_desactivar_accesibilidad(bool sw)
    {
        UAP_sw = sw;
    }

    // activates and unables the accesible mode
    public void UAP_active()
    {
        Debug.Log(accesibilty.UAP_sw);
        UAP_AccessibilityManager.EnableAccessibility(accesibilty.UAP_sw);
    }

    // activates the function to read page
    public void read_page()
    {
        if (!sw_read)
        {
            UAP_AccessibilityManager.EnableAccessibility(true);
            sw_read = true;
        }
        else
        {
            UAP_AccessibilityManager.EnableAccessibility(false);
            sw_read = false;
        }
        popUpObject.SetActive(false);

    }

    // it's called when the user opens the app for the first time and completes the initial scene
    public void First()
    {
        PlayerPrefs.SetString("primera", ".");
    }
}
