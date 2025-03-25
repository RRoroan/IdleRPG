using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
    public NavMeshAgent agent; // �׺���̼� ������Ʈ
    private Transform target; // �̵��� ��ǥ (��)

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        FindNearestEnemy();
        MoveToEnemy();
    }

    void FindNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = Mathf.Infinity;
        Transform closestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy.transform;
            }
        }

        target = closestEnemy;
    }

    void MoveToEnemy()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}
