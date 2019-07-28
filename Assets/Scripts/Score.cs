using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
     public static int _score=0;
    void Start()
    {
        _score = 0;
    }

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = _score.ToString();
    }

}
