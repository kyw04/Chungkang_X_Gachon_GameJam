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
    public GameObject gameover;

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
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
