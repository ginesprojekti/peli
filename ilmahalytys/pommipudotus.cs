using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pommipudotus : MonoBehaviour {


    public GameObject rajahdys = null;
    private float laskuri = 0f;
    


	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        this.laskuri += Time.deltaTime;




        if (this.GetComponent<Transform>().position.y < -4f)
        {

            GameObject apuRajahdys = Instantiate(this.rajahdys, this.GetComponent<Transform>().position, Quaternion.identity);
            Destroy(apuRajahdys.gameObject, 1f);
            Destroy(this.gameObject);
            

        }

        if (this.laskuri > 10f)
        {

        }
		
	}


    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.Equals("taustatesti"))
        {

            GameObject apuRajahdys = Instantiate(this.rajahdys, this.GetComponent<Transform>().position, Quaternion.identity);
            Destroy(apuRajahdys.gameObject, 2f);
            Destroy(this.gameObject);

        }
    } */


}
