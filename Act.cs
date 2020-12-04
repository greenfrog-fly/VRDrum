using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act : MonoBehaviour
{
    //recordの制御
    GameObject start;
    GameObject meme;


    public GameObject stop;
    public GameObject stop1;


    GameObject playobj;
    Recording recording;



    // Start is called before the first frame update
    void Start()
    {
        start = this.gameObject;

        meme = GameObject.Find("GameObj");
        recording = meme.GetComponent<Recording>();


        playobj = GameObject.Find("playing(Clone)"); //クローンが削除されていなかった場合
        Destroy(playobj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("stick"))
        {
            stop1 = Instantiate(stop) as GameObject;
            recording.start();
            Destroy(start);
            

        }
    }
}
