using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonObunga : MonoBehaviour
{
    public GameObject block1, block2, block3,obunga;
    public Collider collision;
    public bool block;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            obunga.SetActive(true);
            if (block)
            {

                block1.SetActive(true); block2.SetActive(true);
                block3.SetActive(true);
            }
            collision.enabled = false;
        }
    }
}
