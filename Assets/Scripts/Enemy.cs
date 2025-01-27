﻿using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public float startSpeed = 10f;
    public float startHealth = 100;

    [Header("Unity Stuff")]

    public Image healthBar;

    private bool isDead = false;

    [HideInInspector]
    public float speed = 10f;

    private float health;

    public int reward = 25;

    public GameObject deathEffect;

    void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }

    void Die()
    {
        isDead = true;

        PlayerStats.Money += reward;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);
    }
}

