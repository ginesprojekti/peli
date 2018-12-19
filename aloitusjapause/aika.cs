using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class aika : MonoBehaviour {
    

    public int aika1;
    public int aika2;
    static int aika3;
    


    public Text aikaon;
  
    bool onkopause = false;
    

    // Use this for initialization
    void Start () {


       



        aikaon.text = ("Aikasi: " + aika3);
        
        

    }
    void Update()
    {
        
        if (pause.Pausella == true)
        {
            onkopause = true;

        }
        if (pause.Pausella == false)
        {
            onkopause = false;
        }
        if (onkopause == false )
        {
            
            aika1++;
            
           
        }


        if (aika1 * Time.deltaTime >= 1.2f )
        {
            aika2++;
            aika1 = 0;
            aika3 = aika2;
            
        }

      
     aikaon.text = ("Aika: " + aika3);
         
    }
    
  

}
