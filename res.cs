using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class res : MonoBehaviour
{
    //不使用
    public GameObject start;
    public GameObject start1;
    // Start is called before the first frame update
    void Start()
    {
        start1 = Instantiate(start) as GameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
