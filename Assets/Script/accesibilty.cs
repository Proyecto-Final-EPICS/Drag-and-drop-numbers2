using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accesibilty : MonoBehaviour
{
    public static bool UAP_sw;
    public static bool sw_read = false;
    public GameObject popUpObject;

    public void activar_desactivar_accesibilidad(bool sw)
    {
        UAP_sw = sw;
    }
    /*void Start()
    {
        UAP_active();
        UAP_AccessibilityManager.SetLanguage("spanish");
    }*/
    public void UAP_active()
    {
        Debug.Log(accesibilty.UAP_sw);
        UAP_AccessibilityManager.EnableAccessibility(accesibilty.UAP_sw);
    }

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
    public void First()
    {
        PlayerPrefs.SetString("primera", ".");
    }
}
