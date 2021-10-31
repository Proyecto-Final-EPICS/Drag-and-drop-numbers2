using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accesibilidad : MonoBehaviour
{
    static bool sw_text = false;
    static bool sw_space = false;
    static int font_family = 1;

    public Font f_1;
    public Font f_2;
    public Font f_3;

    public void Text_plus(int num)
    {
        Text[] texts = FindObjectsOfType<Text>(); ;
        foreach (Text t in texts)
        {
            if (t.tag != "Text")
            {
                if (sw_text)
                {
                    t.fontSize = t.fontSize - num;
                }
                else
                {
                    t.fontSize = t.fontSize + num;
                }
            }
            
        }
        if (sw_text)
        {
            sw_text = false;
        }
        else
        {
            sw_text = true;
        }
    }

    public void space_plus()
    {
        Text[] texts = FindObjectsOfType<Text>(); 
        foreach (Text t in texts)
        {
            if (t.tag != "Text")
            {
                char[] charArr = t.text.ToCharArray();
                if (sw_space)
                {
                    string temp = "";
                    for (int i = 0; i < charArr.Length-1; i++)
                    {
                        char ch = charArr[i];
                        char ch_n = charArr[i+1];
                        if (ch != (char)32)
                        {
                            temp = temp + ch;
                        }else if (ch == (char)32 && ch_n == (char)32)
                        {
                            temp = temp + " ";
                        }
                    }
                    if (charArr.Length > 0)
                    {
                        temp = temp + charArr[charArr.Length - 1];
                    }   
                    t.text = temp;
                }
                else
                {
                    string temp = "";
                    foreach (char ch in charArr)
                    {
                        temp = temp + " " + ch;
                    }
                    t.text = temp;

                }
            }

        }
        if (sw_space)
        {
            sw_space = false;
        }
        else
        {
            sw_space = true;
        }

    }

    public void font_change()
    {
        Text[] texts = FindObjectsOfType<Text>();
        Font Font_selected = null;
        switch (font_family)
        {
            case 1:
                Font_selected = f_2;
                font_family = 2;
                break;
            case 2:
                Font_selected = f_3;
                font_family = 3;
                break;
            case 3:
                Font_selected = f_1;
                font_family = 1;
                break;
            default:
                break;
                
        }
        foreach (Text t in texts)
        {
            t.font = Font_selected;
        }
    }
}
                


