using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saisei : MonoBehaviour
{
    //playの制御
    GameObject meme;
    Recording recording;

    GameObject play;

   

    // Start is called before the first frame update
    void Start()
    {
        meme = GameObject.Find("GameObj");
        recording = meme.GetComponent<Recording>();
        play = this.gameObject;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("stick"))
        {
            
            recording.RecordPlay();
            Destroy(play);
            


        }
    }

}
