using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject loadingScreen, menuObj, settingObj, controlObj;
    public string sceneName, sceneName2;
    public Button continueButton;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("level") == 0)
        {
            continueButton.interactable = false;
        }
    }
    public void PlayGame()
    {
        loadingScreen.SetActive(true);
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene(sceneName);
    }
    public void continueGame()
    {
        loadingScreen.SetActive(true );
        if (PlayerPrefs.GetInt("level") == 2)
        {
            SceneManager.LoadScene(sceneName2);
        }
        if (PlayerPrefs.GetInt("level",1)==1)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void SettingsMenu()
    {
        menuObj.SetActive(false);
        settingObj.SetActive(true);
    }
    public void controlMenu()
    {
        menuObj.SetActive(false);
        controlObj.SetActive(true);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
        Debug.Log("Hlooo");
    }
    public void backToMenu()
    {
        settingObj.SetActive(false);
        controlObj.SetActive(false);
        menuObj.SetActive(true);
    }
}
