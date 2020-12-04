using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act2 : MonoBehaviour
{
    //stopの制御
    GameObject stop;

   
    public GameObject rec;
    public GameObject rec1;


    public GameObject delete;
    public GameObject delete1;


    GameObject meme;
    Recording recording;



    // Start is called before the first frame update
    void Start()
    {
        stop = this.gameObject;
        rec1 = Instantiate(rec) as GameObject;

        meme = GameObject.Find("GameObj");
        recording = meme.GetComponent<Recording>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("stick"))
        {
            
            delete1 = Instantiate(delete) as GameObject;
            
            recording.stop();
            Destroy(stop);
            Destroy(rec1);


        }
    }
}
