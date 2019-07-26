using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomPole : MonoBehaviour
{
    public float maxTime = 1;
    private float timer=0;
    public GameObject Polle;
    public float Height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newpole = Instantiate(Polle);
        newpole.transform.position = transform.position + new Vector3(0, Random.Range(-Height, Height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpole = Instantiate(Polle);
            newpole.transform.position = transform.position + new Vector3(0, Random.Range(-Height, Height), 0);
            Destroy(newpole, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
