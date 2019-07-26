using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomPole : MonoBehaviour
{
    public GameObject Polle;

    private float _sizePosition=0.3f;
    private float _maxTime = 1;
    private float _timer=0;

    void Start()
    {
        Destroy(NewPole(), 15);
    }

    void Update()
    {
        if (_timer > _maxTime)
        {
            Destroy(NewPole(), 15);
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }

    public GameObject NewPole()
    {
        GameObject newpole = Instantiate(Polle);
        newpole.transform.position = transform.position
            + new Vector3(0, Random.Range(-_sizePosition, _sizePosition), 0);
        return newpole;
    }
}
