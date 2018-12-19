using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour {

    public static bool Pausella = false;
    public GameObject pauseMenuUI;
    public aika aika;
    // Update is called once per frame
    void Start()
    {
        aika = GameObject.FindGameObjectWithTag("aika2").GetComponent<aika>();
    }
    void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pausella)
            {
                Resume();
                Time.timeScale = 1f;
            }
            else
            {
                Pause(); 

            }
        }
	}
   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Pausella = false;

    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Pausella = true;
    }
    public void Menuun()
    {

        Time.timeScale = 1f;
        Application.Quit();

    }
    public void Alkuun()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("menu");
        aika.aika2 = 0;

        Pausella = false;

    }
}
