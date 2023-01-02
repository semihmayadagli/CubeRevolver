using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralManagement : MonoBehaviour
{
    GameObject cubeTag;
    public bool durum;
    public GameObject material;

    // Start is called before the first frame update
    void Start()
    {
        cubeTag = GameObject.FindWithTag("Cube");
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Mathf.Abs(cubeTag.transform.rotation.eulerAngles.x)<= 20 && !durum)
        {
            durum = true;            
        }
                
    }

    public void ChangeColor() 
    {
        material.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        
    }


}
