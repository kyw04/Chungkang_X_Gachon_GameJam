using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float score;
    void Start()
    {
        score = 0.0f;
    }

    void Update()
    {
        if (true)
        {
            score += 100f;
        }
    }
}
