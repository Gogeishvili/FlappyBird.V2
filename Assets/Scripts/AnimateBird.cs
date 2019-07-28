using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBird : MonoBehaviour
{
    private Rigidbody2D _rgb;
    public GameManager gameManager;

    private float _velocity = 2;

    void Start()
    {
        _rgb = GetComponent<Rigidbody2D>();
        _rgb.simulated = false;
    }

    void Update()
    {
        
        if (StartGame())
            _rgb.velocity = Vector2.up * _velocity;

    }

    public bool StartGame()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rgb.simulated = true;
            return true;
        }

        return false;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        gameManager.GameOver();
    }
}
