using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject Obj;
    public float activeTime;
    public bool triggerbased;
    private void FixedUpdate()
    {
        if (triggerbased == false)
        {
            if (Obj.active== true)
            {
                StartCoroutine(disableObj());
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Obj.SetActive(false);
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
    IEnumerator disableObj()
    {
        yield return new WaitForSeconds(activeTime);
        Obj.SetActive(false);
    }
}
