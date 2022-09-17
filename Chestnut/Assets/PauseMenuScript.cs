using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            if(GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
    }

    public void PlayGame (){
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }


    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(){
        Debug.Log("loading menu");
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void QuitGame(){
        Debug.Log("Quitting game");
    }

}