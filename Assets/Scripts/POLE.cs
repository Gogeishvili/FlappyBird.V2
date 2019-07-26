using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POLE : MonoBehaviour
{

    void Start(){}

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime;
    }
}
