using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;

    public int health = 100;

    public int value = 50;

    public GameObject deathEffect;

    private Transform target;
    private int waypointIndex = 0;

    void Start()
    {
        target = Waypoints.points[0];
    }

    public void TakeDammage(int amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        PlayerStats.money += value;

        GameObject deathParticles = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(deathParticles, 2f);

        Destroy(gameObject);
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) <= 0.3f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        if(waypointIndex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }

    private void EndPath()
    {
        PlayerStats.lives--;
        Destroy(gameObject);
    }

}
