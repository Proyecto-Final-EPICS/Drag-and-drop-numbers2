using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Game
{
    public string idseccion;
    public string idgame;
    public string namegame;
    public int Totalp;
    public int pcorrectas;
    public int pincorrectas;
    public List<Level> levels;
}