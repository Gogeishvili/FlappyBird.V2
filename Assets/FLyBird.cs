using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLyBird : MonoBehaviour
{
    public float Velocity = 1;
    private Rigidbody2D RG;
    void Start()
    {
        RG = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RG.velocity = Vector2.up * Velocity;
        }
    }
}
