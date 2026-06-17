using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement_3 : MonoBehaviour
{
    public NavMeshAgent navAgent1; // NPC 1's NavMeshAgent
    public NavMeshAgent navAgent2; // NPC 2's NavMeshAgent
    public NavMeshAgent navAgent3; // NPC 2's NavMeshAgent

    public CustomNavMeshAgent agent1;
    public CustomNavMeshAgent agent2;
    public CustomNavMeshAgent agent3;

    public Animator animator1; // Animator for NPC 1
    public Animator animator2; // Animator for NPC 2
    public Animator animator3;
    public RuntimeAnimatorController newAnimatorController; // Predefined animator controller

    public void EnableNPCMovement()
    {
        // Enable NavMeshAgents
        navAgent1.enabled = true;
        navAgent2.enabled = true;
        agent1.enabled = true;
        agent2.enabled = true;

        // Replace Animator Controllers
        animator1.runtimeAnimatorController = newAnimatorController;
        animator2.runtimeAnimatorController = newAnimatorController;

        // Start walking animation
        animator1.SetBool("isWalking", true);
        animator2.SetBool("isWalking", true);
    }

    public void EnableNPCMovement1()
    {
        navAgent3.enabled = true;
        agent1.enabled = true;
        agent3.enabled = true;

        // Replace Animator Controllers
        animator3.runtimeAnimatorController = newAnimatorController;

        // Start walking animation
        animator1.SetBool("isWalking", true);
        animator2.SetBool("isWalking", true);
    }
}
