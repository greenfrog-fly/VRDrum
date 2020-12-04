using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    //色変更
    public Material colorA;
    public Material colorB;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = colorA.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("stick"))
        {
            StartCoroutine("Jony");
            
        }
    }

    IEnumerator Jony()
    {
        
        GetComponent<Renderer>().material.color = colorB.color;

        yield return new WaitForSeconds(0.1f);

        GetComponent<Renderer>().material.color = colorA.color;

        
        yield break;
    }
}
