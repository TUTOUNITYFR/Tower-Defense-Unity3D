using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public float startSpeed = 10;
    [HideInInspector]
    public float speed;
    public float startHealth = 100f;
    private float health;
    public int worth = 50;

    public GameObject deathEffect;

    public Image healthbar;

    public void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDammage(float amount)
    {
        health -= amount;

        healthbar.fillAmount = health / startHealth;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Slow(float amount)
    {
        speed = startSpeed * (1f - amount);
    }

    private void Die()
    {
        PlayerStats.money += worth;

        GameObject deathParticles = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(deathParticles, 2f);

        Destroy(gameObject);
    }

}
