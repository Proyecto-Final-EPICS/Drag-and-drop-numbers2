using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accesibilidad : MonoBehaviour
{
    static int sw_text = 0;
    static bool sw_space = false;
    static bool sw_contrast = false;
    static int cont = 0;
    static int font_family = 1;
    public Color[] colors_bk;

    public Font f_1;
    public Font f_2;
    public Font f_3;

    public GameObject popUpObject;
    private const float DarkGrey = 0.07f;
    private readonly Color _darkGrey = new Color(DarkGrey, DarkGrey, DarkGrey, 1);


    public void Text_plus(int num)
    {
        Text[] texts = FindObjectsOfType<Text>(); ;
        foreach (Text t in texts)
        {
            if (t.tag != "Text")
            {
                if (sw_text == 2)
                {
                    t.fontSize = t.fontSize - 2*num;
                }
                else
                {
                    t.fontSize = t.fontSize + num;
                }
            }
            
        }
        if (sw_text == 0 || sw_text == 1)
        {
            sw_text = sw_text+1;
        }
        else
        {
            sw_text = 0;
        }
        popUpObject.SetActive(false);
    }

    public void space_plus()
    {
        Text[] texts = FindObjectsOfType<Text>(); 
        foreach (Text t in texts)
        {
            if (t.tag != "Text")
            {
                char[] charArr = t.text.ToCharArray();
                string temp = "";
                if (sw_space)
                {
                    for (int i = 0; i < charArr.Length-2; i++)
                    {
                        char ch = charArr[i];
                        char ch_n = charArr[i+1];
                        char ch_nn = charArr[i + 2];
                        if (ch != (char)32)
                        {
                            temp = temp + ch;
                        } if (ch == (char)32 && ch_n == (char)32 && ch_nn == (char)32)
                        {
                            temp = temp + " ";
                        }
                    }
                    if (charArr.Length > 0)
                    {
                        temp = temp + charArr[charArr.Length - 1];
                    }   
                }
                else
                {
                    foreach (char ch in charArr)
                    {
                        temp = temp + " " + ch;
                    }
                }
                t.text = temp;
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
        popUpObject.SetActive(false);

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
            if(t.tag != "numbers")
            {
                t.font = Font_selected;
            } 
        }
        popUpObject.SetActive(false);
    }

    public void increase_contrast()
    {
        /*Image[] images = FindObjectsOfType<Image>();

        if (cont == 0)
        {
            colors_bk = new Color[images.Length];
            Debug.Log(images.Length);
            for (int i = 0; i < images.Length; i++)
            {
                Color c = images[i].color;
                colors_bk[i] = c;
            }
            cont = cont + 1;

        }


        if (!sw_contrast)
        {
            foreach (Image i in images)
            {
                Color c = i.color;
                c.a = 255;
                i.color = c;
            }
            sw_contrast = true;
        }
        else
        {
            Debug.Log(images.Length);
            for (int i = 0; i < images.Length; i++)
            {
                images[i].color = colors_bk[i];
            }
            sw_contrast = false;
        }*/

            foreach (var text in FindObjectsOfType<Text>(true))
            {
                if(text.tag != "LevelRectangle" && text.tag != "numbers")
            {
                text.color = text.color == Color.white ? _darkGrey : Color.white;
            }
                
            }
            foreach (var image in FindObjectsOfType<Image>(true))
            {
            if (image.tag != "LevelRectangle" && image.name != "Touch Blocker" && image.name != "Active Item Frame" && image.name != "Active Item Frame Template")
            {
                image.color = image.color == Color.white ? _darkGrey : Color.white;
            }
           
            }
            sw_contrast = true;
        popUpObject.SetActive(false);
    }
}



