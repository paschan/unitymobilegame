using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject quitButton;
    public GameObject restartButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restart(){
         SceneManager.LoadScene("MainMenu");
    }
    public void quit(){
        Application.Quit();
    }
}
