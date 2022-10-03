using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn: MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
    }
}
