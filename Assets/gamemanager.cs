using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public GameObject endPanel;
    public AudioSource asource;
    public AudioClip aclip;
    public GameObject pausePanel;
    public bool pas;

    public void EndGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
 public void LevelWon()
    {
        asource.PlayOneShot(aclip);
        endPanel.SetActive(true);
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("START");
    }
    public void pausemenu()
    {
        pausePanel.SetActive(true);
        pas = true;
        
    }
    public void resume()
    {
        pausePanel.SetActive(false);

        pas = false;
    }
}
