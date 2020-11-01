using System;
 using UnityEngine;
 
 public class Pause : MonoBehaviour
 {
     bool paused = false;
 
     void Update()
     {
         if(Input.GetKeyDown(KeyCode.P))
             paused = togglePause();
     }
     
     void OnGUI()
     {
         if(paused)
         {
             GUI.Label(new Rect(Screen.width/2, Screen.height/2, 1000, 20), "JOGO PAUSADO");
         }
     }
     
     bool togglePause()
     {
         if(Time.timeScale == 0f)
         {
             Time.timeScale = 1f;
             return(false);
         }
         else
         {
             Time.timeScale = 0f;
             return(true);    
         }
     }
 }