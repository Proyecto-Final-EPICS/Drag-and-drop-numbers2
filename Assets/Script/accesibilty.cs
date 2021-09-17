using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accesibilty : MonoBehaviour
{
    public static bool UAP_sw;
    public void activar_desactivar_accesibilidad(bool sw)
    {
        UAP_sw = sw;
    }

    void Start()
    {
        UAP_active();
    }
    public void UAP_active()
    {
        Debug.Log(accesibilty.UAP_sw);
        UAP_AccessibilityManager.EnableAccessibility(accesibilty.UAP_sw);
    }
}
