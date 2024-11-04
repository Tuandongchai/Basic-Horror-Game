using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Door : MonoBehaviour
{
    public GameObject intText, key, lockedText;
    public bool interactable, toggle;
    public Animator doorAnim;
    public AudioSource soundDoor;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(key.active==false)
                {
                    toggle = !toggle;
                    if (toggle == true)
                    {
                        doorAnim.ResetTrigger("close");
                        doorAnim.SetTrigger("open");
                        soundDoor.Play();
                    }
                    if (toggle == false)
                    {
                        doorAnim.ResetTrigger("open");
                        doorAnim.SetTrigger("close");
                        soundDoor.Play();
                    }
                    intText.SetActive(false);
                    interactable = false;
                }
                if(key.active == true)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }
                
            }
        }
    }
    IEnumerator disableText()   
    {
        yield return new WaitForSeconds(2.0f);
        lockedText.SetActive(false);
    }
}