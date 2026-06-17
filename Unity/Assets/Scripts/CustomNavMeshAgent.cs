using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CustomNavMeshAgent : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;

    public Transform targetTransform;
    public Vector3 targetPosition;

    public float timer = 6f;
    public float distance = 5f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if there is a valid target position
        if (targetPosition != Vector3.zero)
        {
            // Move the agent to the specific target position
            agent.SetDestination(targetPosition);

            // Animation logic for walking
            if (agent.remainingDistance > agent.stoppingDistance)
            {
                animator.SetBool("isWalking", true);
            }
            else
            {
                animator.SetBool("isWalking", false);
            }
        }
        else
        {
            // Optional: Random movement logic if no target is set
            timer -= Time.deltaTime;
            if (timer <= 0.1f)
            {
                Vector3 newPos = GetRandomPointOnNavMesh(transform.position, distance);
                agent.SetDestination(newPos);
                timer = 6f;
            }
        }

        Vector3 GetRandomPointOnNavMesh(Vector3 origin, float distance)
    {
        Vector3 randomDirection = Random.insideUnitSphere * distance;
        randomDirection += origin;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randomDirection, out navHit, distance, NavMesh.AllAreas);

        return navHit.position;
    }
    }
}
