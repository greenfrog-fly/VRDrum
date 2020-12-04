using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class vivere : MonoBehaviour
{
    //不使用
    public GameObject stick1;
    public GameObject stick2;
    public GameObject Stick;
    public GameObject right;
    public GameObject left;


    // Start is called before the first frame update
    void Start()
    {
        stick1 = Instantiate(Stick) as GameObject;
       // stick2 = Instantiate(Stick) as GameObject;

        stick1.transform.parent = right.transform;
        stick2.transform.parent = left.transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
