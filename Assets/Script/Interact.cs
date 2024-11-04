using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Interact : MonoBehaviour
{
    public bool interactable, toggle;
    public GameObject inttext, dialogue;
    public string dialogueString;
    public Text dialogueText;
    public float dialogueTime;
    public AudioSource sound;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(toggle==false)
            {
                inttext.SetActive(true);
                interactable = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera")){
            inttext.SetActive(false);
            interactable = false;
        }
    }
    
    private void Update()
    {
        if (interactable==true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueText.text = dialogueString;
                dialogue.SetActive(true);
                inttext.SetActive(false);
                StartCoroutine(disableDialogue());
                sound.Play();
                toggle = true;
                interactable=false;
            }
        }
    }
    IEnumerator disableDialogue()
    {
        yield return new WaitForSeconds(dialogueTime);
        dialogue.SetActive(false);
    }
}
