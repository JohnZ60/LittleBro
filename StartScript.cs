using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScript : MonoBehaviour
{
    bool nextLevel = false;
    //public GameObject endOfLevelScreen;
    public GameObject beginingOfLevelScreen;

    void Update()
    {
        if (nextLevel)
        {
            NextLevel(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void StartGame(){
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame(){
        Application.Quit();
    }
    
    public void NextLevel(int level)
    {
        Time.timeScale = 0;
        //endOfLevelScreen.gameObject.SetActive(true);
        if (nextLevel)
        {
            nextLevel = false;
            //endOfLevelScreen.gameObject.SetActive(false);
            Time.timeScale = 1;
            SceneManager.LoadScene(level);
        }
    }

    public void SetNextLevelToTrue()
    {
        nextLevel = true;
    }

    public void SetBeginScreenDeactive()
    {
        beginingOfLevelScreen.SetActive(false);
        Time.timeScale = 1;
    }

}
