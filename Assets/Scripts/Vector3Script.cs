using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Script : MonoBehaviour
{

    public Vector3 myVector3;
    public GameObject myObject;
    void Start()
    {
        myObject.transform.eulerAngles = myVector3;
    }

    
    void Update()
    {
        
    }
}
