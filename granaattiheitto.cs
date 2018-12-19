using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granaattiheitto : MonoBehaviour {
    private GameObject heitto = null;
    public GameObject granaattipre = null;
    
    private int tuhoanaatti = 0;
	// Use this for initialization
	void Start () {
        this.heitto = GameObject.Find("heitto");

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject apu = Instantiate(this.granaattipre, this.heitto.GetComponent<Transform>().position, this.heitto.GetComponent<Transform>().rotation);
            apu.GetComponent<Rigidbody2D>().AddForce(new Vector2(700, 500));

           
            Destroy(apu, 3);

        }
        
	}
}
