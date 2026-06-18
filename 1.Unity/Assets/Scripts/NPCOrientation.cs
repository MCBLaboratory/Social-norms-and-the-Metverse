using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCOrientation : MonoBehaviour
{
    public Transform playerTransform;
    private float rotationSpeed = 2.0f;
    private Coroutine rotationCoroutine;

    private IEnumerator RotateTowardsPlayer()
    {
        while(true)
        {
            Vector3 direction = playerTransform.position - transform.position;
            direction.y = 0;

            Quaternion targetRotation = Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            if(Quaternion.Angle(transform.rotation, targetRotation) <= 5.0f) {break;}
            
            yield return null;
        }       
    }

    public void ActivateNPC()
    {
        rotationCoroutine = StartCoroutine(RotateTowardsPlayer());
    }
}
