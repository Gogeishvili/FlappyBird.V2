using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLyBird : MonoBehaviour
{
    public GameManager gameManager;
    public float Velocity = 2;//დასარეგულირებელია
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
    private void OnCollisionEnter2D(Collision2D coll)
    {
        gameManager.GameOver();
    }
}
