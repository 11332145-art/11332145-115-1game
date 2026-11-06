using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HP : MonoBehaviour
{
    [Header("玩家生命值")]
    public int maxHP = 5;
    private int currentHP;

    [Header("受傷間隔")]
    public float damageInterval = 1f;
    private float damageTimer = 0f;

    [Header("UI")]
    public TMP_Text hpText;
    public GameObject gameOver;
    private bool isDead = false;

    void Start()
    {
        currentHP = maxHP;

        UpdateHP();

        if (gameOver != null)
        {
            gameOver.SetActive(false);
        }
    }

    void Update()
    {
        if (damageTimer > 0f)
        {
            damageTimer -= Time.deltaTime;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        if (isDead || damageTimer > 0f)
            return;

        currentHP -= 1;

        currentHP = Mathf.Max(currentHP, 0);
        damageTimer = damageInterval;
        UpdateHP();

        if (currentHP <= 0)
        {
            GameOver();
        }
    }

    void UpdateHP()
    {
        if (hpText != null)
        {
            hpText.text =
                "HP: " + currentHP + " / " + maxHP;
        }
    }

    void GameOver()
    {
        isDead = true;

        if (gameOver != null)
        {
            gameOver.SetActive(true);
        }

        Time.timeScale = 0f;
    }

}
