using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kamerakoodi : MonoBehaviour {

    public Transform hahmo;
    public Scene scene;
    public float matka = 10f;
    
  

    void Start()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height/2.5f / matka));
       
      
    }



    // Update is called once per frame
    void Update () {
        if(hahmo.position.y < -10)
        {
            SceneManager.LoadScene("scene2");
        }
        if (hahmo.position.y > 150 && hahmo.position.y < 400)
        {

            SceneManager.LoadScene("scene3");
            Time.timeScale = 0f;

        }
        transform.position = new Vector3(hahmo.position.x, hahmo.position.y+ 2f , transform.position.z);
      
        

    }


}
