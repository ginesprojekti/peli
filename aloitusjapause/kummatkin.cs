using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kummatkin : MonoBehaviour
{
    public GameObject logo;
    
    public float aika = 0;
    
    private void Start()
    {
        logo = GameObject.Find("nimi");
    }
    public void Pelaa()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Lopeta()
    {

        Application.Quit();
    }
    private void Update()
    {
        aika = aika + 0.04f;
        if(aika > 0 && aika <10)
        {
            logo.transform.position = new Vector3(logo.transform.position.x, logo.transform.position.y + 0.05f, 0);
        }
        if (aika >= 10 && aika <=20)
        {
            logo.transform.position = new Vector3(logo.transform.position.x, logo.transform.position.y - 0.05f, 0);
            
        }
        if(aika > 20)
        {

            aika = 0;
        }
    }


}
