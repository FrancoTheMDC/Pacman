using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostMovement : MonoBehaviour
{
    public Transform[] waypoints;
    int current = 0;

    public float speed = 0.3f;

    void FixedUpdate()
    {
        if (transform.position != waypoints[current].position)
        {
            Vector2 position = Vector2.MoveTowards(transform.position, waypoints[current].position, speed);
            GetComponent<Rigidbody2D>().MovePosition(position);
        }
        else
        {
            current = (current + 1) % waypoints.Length;
        }

        Vector2 direction = waypoints[current].position - transform.position;
        GetComponent<Animator>().SetFloat("DirX", direction.x);
        GetComponent<Animator>().SetFloat("DirY", direction.y);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Pacman")
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
