using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform tpPoint;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Pacman")
        {
            collider.GetComponent<Collider2D>().GetComponent<Transform>().position = tpPoint.position;
        }
    }

    
}
