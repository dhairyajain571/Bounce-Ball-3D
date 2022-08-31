using UnityEngine.SceneManagement;
using UnityEngine;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
  public void play()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void quit()
    {
        Application.Quit();
    }
}
