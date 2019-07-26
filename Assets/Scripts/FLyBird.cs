using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLyBird : MonoBehaviour
{
    private Rigidbody2D _rgb;
    public GameManager gameManager;

    private float _velocity = 2;
   
    void Start()
    {
        _rgb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rgb.velocity = Vector2.up * _velocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        gameManager.GameOver();
    }
}
