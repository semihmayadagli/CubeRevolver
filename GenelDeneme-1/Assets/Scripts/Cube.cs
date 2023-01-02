using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{   

    void Update()
    {
        transform.Rotate(90*Time.deltaTime,0,0);
        
    }
}
