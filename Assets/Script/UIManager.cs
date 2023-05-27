using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public PlayerHp playerHp;
    public Image hpImage;
    public TextMeshProUGUI currentHpText;
    public TextMeshProUGUI maxHpText;

    private float startHp;

    private void Start()
    {
        //startHp = playerHp.hp;
    }

    private void Update()
    {
        //hpImage.fillAmount = playerHp.hp / startHp;
        //currentHpText.text = playerHp.hp.ToString("F0");
        maxHpText.text = startHp.ToString("F0");
    }
}
