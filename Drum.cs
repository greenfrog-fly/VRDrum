using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Valve.VR;

public class Drum : MonoBehaviour
{
    //stickの制御
    private AudioSource drum_audio;
    

    public SteamVR_Input_Sources hand;
    public SteamVR_Action_Vibration vibration;

    public GameObject playing;
    public GameObject playing1;



    public void Start()
    {
 
        drum_audio = gameObject.AddComponent<AudioSource>();


    }



    public void Update()
    {



    }

    

        public void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.CompareTag("tam1"))
        {

            vibration.Execute(0, 0.1f, 100, 1f, hand);
   
        }
        else if (collision.gameObject.CompareTag("tam2"))
        {

            
            vibration.Execute(0, 0.1f, 100, 1f, hand);
            
        }
        else if (collision.gameObject.CompareTag("tam3"))
        {

            
            vibration.Execute(0, 0.1f, 100, 1f, hand);
            
        }
        else if (collision.gameObject.CompareTag("snare"))
        {

            
            vibration.Execute(0, 0.1f, 100, 1f, hand);
            
        }
        else if (collision.gameObject.CompareTag("sinb"))
        {

            
            vibration.Execute(0, 0.1f, 100, 1f, hand);
            
        }
        else if (collision.gameObject.CompareTag("sinb2"))
        {

            
            vibration.Execute(0, 0.1f, 100, 1f, hand);
            
        }
       
    }

    

   
    

    


}
