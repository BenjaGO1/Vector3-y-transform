using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 movement;


    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (transform.eulerAngles.y < 160)
        {
            transform.eulerAngles += movement;
        }
    }
}
