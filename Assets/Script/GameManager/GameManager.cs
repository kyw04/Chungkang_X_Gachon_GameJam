using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        if (Time.timeScale != 1) { Time.timeScale = 1f; }
    }
}
