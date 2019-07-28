using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    private bool isGameStarted = false;

    void Start() { }

    void Update()
    {

        if (isGameStarted == false && Input.GetMouseButtonDown(0))
            isGameStarted = true;

        if (isGameStarted)
            transform.position += Vector3.left * Time.deltaTime;

    }
}
