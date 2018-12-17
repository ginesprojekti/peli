using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kanuunakoodi1 : MonoBehaviour {

    // Kamera
    private GameObject kamera = null;

    public GameObject kuula = null;
    private GameObject tahtain = null;

    private float laskuri = 0f;
    private float laskuri2 = 0f;
    private float kulma = 0f;

    void Start()
    {
        // Haetaan valmiiski
        this.tahtain = GameObject.Find("tahtain");
        this.kamera = GameObject.Find("kamera");

    }  // Start
	
	void Update () {

        this.laskuri += (Time.deltaTime * 30f);
        this.laskuri2 += (Time.deltaTime * 30f);

        // Otetaan kanuunan piipun kulma talteen
        this.kulma = this.GetComponent<Transform>().rotation.eulerAngles.z;

        if (Input.GetKey(KeyCode.LeftArrow) && (this.kulma < 84f))
        {
            this.GetComponent<Transform>().Rotate(0f, 0f, 1f);
        }  // if

        if (Input.GetKey(KeyCode.RightArrow) && (this.kulma > 5f))
        {
            this.GetComponent<Transform>().Rotate(0f, 0f, -1f);
        }  // if

        if (Input.GetKeyDown(KeyCode.Mouse0) && laskuri2 > 10f)
        {
             // Inttijäbän pistooli
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
            apu.GetComponent<Rigidbody2D>().AddForce(new Vector2(x1, y1) * 10000f);
            Destroy(apu.gameObject, 10f);

            this.laskuri2 = 0f;
        }  // if

        if (Input.GetKey(KeyCode.Mouse1) && laskuri2 > 1f)
        {
            // Inttijäbän AK
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
            apu.GetComponent<Rigidbody2D>().AddForce(new Vector2(x1, y1) * 20000f);
            Destroy(apu.gameObject, 10f);

            this.laskuri2 = 0f;
        }  // if

        if (this.laskuri > 100f && this.laskuri < 120f)
        {
            // Automaatti Kanuuna
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

            this.laskuri = 0f;

        }  // if

    }  // Update
}  // class
