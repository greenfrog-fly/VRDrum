using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    //シーリング回転
    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {

        myTransform.Rotate(0f, 0f, 2.0f);
    }
}
