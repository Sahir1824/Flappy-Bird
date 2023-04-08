using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject gameovercanvas;
    // Start is called before the first frame update
    void Start()
    {

        gameovercanvas.SetActive(false);
        Time.timeScale = 1;
    }

   public void gameOver()
    {
        gameovercanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
