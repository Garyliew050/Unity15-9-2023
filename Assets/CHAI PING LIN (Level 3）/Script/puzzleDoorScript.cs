using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleDoorScript : MonoBehaviour
{

    public Boolean lockA;
    public Boolean lockB;
    public Boolean lockC;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //destroy the object when all the torch is lit up
        if(lockA &&  lockB && lockC)
        {
            Destroy(gameObject);
        }
    }
}
