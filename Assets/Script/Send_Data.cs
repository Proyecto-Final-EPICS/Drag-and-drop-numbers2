using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Bolt;
using System;

// this class is occupied to send the data to the database
public class Send_Data : MonoBehaviour
{
   public SessionGame session;
   public string level;
   public int score_lvl;
   public string idseccion;
   public string idgame;
   public string namegame;
   public float inicioT;
   public float finalT;
   public int totalp;
   public int pcorrectas;
   public int pincorrectas;

    public void send(List<Parameter> prms){
       string username = (string)Variables.Application.Get("username");
       string school = "School_1";
       session.Student = new Student(username,school);
        session.Game.idgame = idgame;
        session.Game.namegame = namegame;
        session.Game.Totalp = totalp;
        session.Game.pcorrectas = pcorrectas;
        session.Appname = (string)Variables.Application.Get("nombreAPP");
        session.Game.pincorrectas = pincorrectas;
        session.Game.idsesion = (int)Variables.Application.Get("Id_sesion");
        session.Time = (float)Variables.Application.Get("FinalT")-(float)Variables.Application.Get("inicioT");


        string json = JsonUtility.ToJson(session);
        UnityWebRequest webRequest = new UnityWebRequest("https://vip-epics-api.herokuapp.com/v2.0/game/session", "PUT");
        byte[] encodedPayload = new System.Text.UTF8Encoding().GetBytes(json);
        webRequest.uploadHandler = (UploadHandler) new UploadHandlerRaw(encodedPayload);
        webRequest.downloadHandler = (DownloadHandler) new DownloadHandlerBuffer();
        webRequest.SetRequestHeader("Content-Type", "application/json");
        
        UnityWebRequestAsyncOperation requestHandel = webRequest.SendWebRequest();
        requestHandel.completed += delegate(AsyncOperation pOperation) {
            Debug.Log(webRequest.responseCode);
            Debug.Log(webRequest.downloadHandler.text);
        };
   }

   public void setLevel(string lvl){
       this.level = lvl;
   }

   public Parameter parameter(string name,string val){
      return new Parameter(name,val);
  }
    public void levelScore(int Id_sesion)
    {
        score_lvl = Id_sesion;
    }
}
