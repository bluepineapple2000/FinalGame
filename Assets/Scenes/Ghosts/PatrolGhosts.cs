using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolGhosts : MonoBehaviour
{
    NavMeshAgent agent;

    public List<Transform> patrolPoints = new List<Transform>();
    int currentPatrolIndex = 0;
    bool isEnd; 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (patrolPoints.Count > 0)
        {
            agent.SetDestination(patrolPoints[currentPatrolIndex].position);
        }
        isEnd = false; 
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (!isEnd)
        {
            currentPatrolIndex++;
        }
        else
        {
            currentPatrolIndex--;
        }
        agent.destination = patrolPoints[currentPatrolIndex].position;

        if (currentPatrolIndex == patrolPoints.Count - 1)
        {
            isEnd = true;
        }
        else if (currentPatrolIndex == 0)
        {
            isEnd = false;
        }

    }
} 
