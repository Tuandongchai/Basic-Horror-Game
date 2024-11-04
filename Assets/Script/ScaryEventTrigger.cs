using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryEventTrigger : MonoBehaviour
{
    public GameObject scary;
    public AudioSource scareSound;
    public Collider collision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scary.SetActive(true);
            //scareSound.Play();
            collision.enabled = false;
        }
    }
}
