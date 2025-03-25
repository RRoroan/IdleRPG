using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDecreaseTrigger : MonoBehaviour
{
    [SerializeField, Tooltip("How much should the player's health decrease by when entering this trigger.")]
    private int healthDecreaseAmount = 10;
    [SerializeField]
    private HealthManagerSO HealthManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthManager.DecreaseHealth(healthDecreaseAmount);
        }
    }
}
