using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationTrigger : MonoBehaviour
{
    public Collider collision;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monster"))
        {
            StartCoroutine(reEnable());
            collision.enabled = false;
        }
    }
    IEnumerator reEnable()
    {
        yield return new WaitForSeconds(6.0f);
        collision.enabled = true;
    }
}