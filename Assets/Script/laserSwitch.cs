using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserSwitch : MonoBehaviour
{
    public Animator switchAnim;
    public GameObject lasers, intText;
    public bool interactable, toggle;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (toggle == false)
            {
                intText.SetActive(true);
                interactable = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    private void Update()
    {
        if(interactable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                switchAnim.SetTrigger("pull");
                lasers.SetActive(false);
                intText.SetActive(false);
                toggle = true;
                interactable= false;
            }
        }
    }
}
