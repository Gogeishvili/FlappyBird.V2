using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomPole : MonoBehaviour
{
    public GameObject Pole;
    
    private float _sizePosition = 0.3f;
    private float _maxTime = 1;
    private float _timer = 0;
    private bool isClicked = false;

    void Start()
    {
        Destroy(NewPole(), 15);
    }

    void Update()
    {
        if (isClicked == false && Input.GetMouseButtonDown(0))
            isClicked = true;

        if (isClicked)
        {
            if (_timer > _maxTime)
            {
                Destroy(NewPole(), 15);
                _timer = 0;
            }
            _timer += Time.deltaTime;
        }
    }

    public GameObject NewPole()
    {

        var newPole = Instantiate(Pole);
        newPole.transform.position = transform.position
            + new Vector3(0, Random.Range(-_sizePosition, _sizePosition), 0);
        return newPole;

    }
}
