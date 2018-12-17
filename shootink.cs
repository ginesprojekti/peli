using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootink : MonoBehaviour {


    private GameObject kamera = null;

    public GameObject kuula = null;
    private GameObject tahtain = null;
    private float kulma = 0f;

    // Use this for initialization
    void Start () {

        // Haetaan valmiiski
        this.tahtain = GameObject.Find("tahtain");
        this.kamera = GameObject.Find("kamera");
    }

    // Update is called once per frame
    void Update()
    {


        }  // if

        void OnTriggerEnter2D(Collider2D other)
        {

        if (other.gameObject.name == "ruski")
        {
            // Luodaan kulla piipun suulle
            GameObject apu = Instantiate(this.kuula, this.tahtain.GetComponent<Transform>().position,
                                                           this.tahtain.GetComponent<Transform>().rotation);
            apu.name = "KuulaX";
            Debug.Log("Kulma: " + kulma);

            // Lasketaan kulmaa vastaava X- ja Y-suuntainen kerroin (0-1)
            float astekulma = this.kulma * Mathf.Deg2Rad;
            float x1 = Mathf.Cos(astekulma);
            float y1 = Mathf.Sin(astekulma);
            Debug.Log("X=" + x1 + " Y=" + y1);

            // kerrotaan kulmakertoimet halutulla voimalla
            apu.GetComponent<Rigidbody2D>().AddForce(new Vector2(x1, y1) * 5000f);
            Destroy(apu.gameObject, 10f);

        }
    
           
        }



}
