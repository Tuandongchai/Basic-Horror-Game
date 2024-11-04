using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObungaJumpscare : MonoBehaviour
{
    public AudioSource obungaSource, killTriggerSource;
    public Animator obungaAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;
    public GameObject cam;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            cam.SetActive(true);
            obungaAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscare());
            obungaSource.enabled = false;
            killTriggerSource.Play();
        }
    }
    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
        killTriggerSource.Stop();
    }
}
