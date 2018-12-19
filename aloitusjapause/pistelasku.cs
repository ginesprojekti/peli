using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pistelasku : MonoBehaviour {

    public int pisteet = 0;
    public int pisteet3 = 0;
    static int pisteet2;
   
    public Text pallot;
   
    
   
   
  
    
    void Start()
    {

        pallot.text = ("Kerätyt Pallot: " + pisteet3);



    }

    // Update is called once per frame
    void Update() {
        pisteet2 = pisteet;


        pisteet3 = pisteet2;

        pallot.text = ("Kerätyt Pallot: " + pisteet);
        


    }

}
