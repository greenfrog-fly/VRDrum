using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recording : MonoBehaviour
{
    //録音再生
    private AudioSource drum_audio;

    public AudioClip audio_tam1;
    public AudioClip audio_tam2;
    public AudioClip audio_tam3;
    public AudioClip audio_snare;
    public AudioClip audio_sinb;

    public GameObject playing;
    public GameObject playing1;
    public GameObject nodata;
    public GameObject nodata1;

    public GameObject play;
    public GameObject play1;
    public GameObject play2;


    public float time = 0.0f;

    public List<float> timing = new List<float>();
    public List<int> oto = new List<int>();
    public List<float> timing2 = new List<float>();
    public List<int> oto2 = new List<int>();

    float n = 0.0f;
    int m = 0;
    float a = 0;
    int p = 0;

    // Start is called before the first frame update
    void Start()
    {
        drum_audio = gameObject.AddComponent<AudioSource>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }



    public void start()
    {
        time = 0.0f;
        timing.Clear();
        oto.Clear();
    }



    public void stop()
    {
        p = timing.Count;
        timing2 = timing;
        oto2 = oto;
    }




    public void RecordPlay()
    {
        
        if (oto.Count > 0)
        {
            
            StartCoroutine("Arex");

            

        }
        else
        {

            nodata1 = Instantiate(nodata) as GameObject;
            
        }

        
    }

    public void RecordStop()
    {
        Destroy(nodata1);
        StopCoroutine("Arex");
    }





    IEnumerator Arex()
    {

        playing1 = Instantiate(playing) as GameObject;

        for (int i = 0; i < p; i++)
        {
            n = timing2[i];
            m = oto2[i];

            yield return new WaitForSeconds(n - a);
            playmusic();
            a = n;

            yield return null;
        }

        yield return new WaitForSeconds(0.5f);

        play1 = Instantiate(play) as GameObject;
        Destroy(playing1);


    }

    public void ace()
    {
        play1 = Instantiate(play) as GameObject;
    }





    public void playmusic()
    {
        if (m == 1)
        {
            drum_audio.PlayOneShot(audio_tam1);
        }
        else if (m == 2)
        {
            drum_audio.PlayOneShot(audio_tam2);
        }
        else if (m == 3)
        {
            drum_audio.PlayOneShot(audio_tam3);
        }
        else if (m == 4)
        {
            drum_audio.PlayOneShot(audio_snare);
        }
        else if (m == 5)
        {
            drum_audio.PlayOneShot(audio_sinb);
        }
    }
}
