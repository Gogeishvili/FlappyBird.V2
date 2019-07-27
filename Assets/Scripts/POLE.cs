using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POLE : MonoBehaviour
{
    public bool answer = false;
    void Start(){}

    void Update()
    {
       
        if (answer == false && Input.GetMouseButtonDown(0))
        {
            answer = true;
            
        }

        if (answer)
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
    }

   
}
