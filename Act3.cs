using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act3 : MonoBehaviour
{
    //deleteの制御
    GameObject delete;
    
    public GameObject record;
    public GameObject record1;
    public GameObject play;
    public GameObject play1;


    GameObject meme;
    Recording recording;


    // Start is called before the first frame update
    void Start()
    {
        delete = this.gameObject;
        play1 = Instantiate(play) as GameObject;

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
            recording.RecordStop();
            record1 = Instantiate(record) as GameObject;


            Destroy(play1);
            Destroy(GameObject.Find("play(Clone)"));
            Destroy(delete);
            


        }
    }
}
