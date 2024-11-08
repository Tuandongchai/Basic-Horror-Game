using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObungaJumpscare1 : MonoBehaviour
{
    public Animator obungaAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;
    public EnemySnowmanAI monsterscript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            monsterscript.enabled = false;
            obungaAnim.ResetTrigger("idle");
            obungaAnim.ResetTrigger("walk");
            obungaAnim.ResetTrigger("run");
            obungaAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscare());
        }
    }
    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }
}
