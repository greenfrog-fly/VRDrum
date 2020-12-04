using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snare : MonoBehaviour
{
    //スネアの制御
    private AudioSource drum_audio;
    public AudioClip audio_snare;

    GameObject meme;
    Recording recording;

    // Start is called before the first frame update
    void Start()
    {
        drum_audio = gameObject.AddComponent<AudioSource>();

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

            drum_audio.PlayOneShot(audio_snare);
            recording.timing.Add(recording.time);
            recording.oto.Add(4);


        }
    }
}
