using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Player player;
    public Image hpImage;
    public TextMeshProUGUI currentHpText;
    public TextMeshProUGUI maxHpText;
    public TextMeshProUGUI timeText;
    public GameObject gameover;

    public TimeManager timeManager;

    private float startHp;

    private void Start()
    {
        player = GameManager.instance.player;
        startHp = player.hp;
    }

    private void Update()
    {
        if (gameover.activeSelf == false && player.hp <= 0)
        {
            gameover.SetActive(true);
            Time.timeScale = 0f;
            return;
        }

        hpImage.fillAmount = player.hp / startHp;
        currentHpText.text = player.hp.ToString("F0");
        maxHpText.text = startHp.ToString("F0");

        timeText.text = timeManager.currentTime.ToString("F1");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
