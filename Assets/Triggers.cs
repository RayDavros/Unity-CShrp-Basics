using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public GameObject plane;
    public Transform planepos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        Instantiate(plane, planepos.position, planepos.rotation);
    }   
}   

