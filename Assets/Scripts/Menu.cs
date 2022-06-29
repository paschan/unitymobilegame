using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject resumeButton;
    public GameObject quitButton;
    public GameObject shopMenu;
    public GameObject shopMenuFont;
    public  void startGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void quitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
    public void pauseGame(){
        Time.timeScale=0f;
        resumeButton.SetActive(true);
        quitButton.SetActive(true);

    }
    public void resumeGame(){
        Time.timeScale=1f;
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
    }
    public void shop(){
        Time.timeScale=0f;
        shopMenu.SetActive(true);
        shopMenuFont.SetActive(true);

    }
    public void closeShop(){
        Time.timeScale=1f;
        shopMenu.SetActive(false);
        shopMenuFont.SetActive(false);
    }
}
