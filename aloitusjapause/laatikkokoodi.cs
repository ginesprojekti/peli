using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laatikkokoodi : MonoBehaviour {
    Rigidbody2D laatikko;
    public int aika = 0;
    public float lahtopiste;
	// Use this for initialization
	void Start () {
        laatikko = GetComponent<Rigidbody2D>();
        lahtopiste = this.laatikko.position.y;
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D laatikko) {
        if (laatikko.gameObject.name.Equals("hahmo"))
        {
            Invoke("TiputaTaso", 0.5f);
           
        }
	}
    void TiputaTaso()
    {
        laatikko.isKinematic = false;
        

    }
    private void Update()
    {
        if(laatikko.isKinematic == false)
        {
            aika++;

        }
        if(aika > 300)
        {
            laatikko.isKinematic = true;
            laatikko.position = new Vector2(this.laatikko.position.x, this.lahtopiste);
            aika = 0;
        }
        if (laatikko.position.y > this.lahtopiste)
        {
            laatikko.position = new Vector2(this.laatikko.position.x, this.lahtopiste);
        }
    }
}
