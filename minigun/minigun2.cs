using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigun2 : MonoBehaviour {

    public GameObject luoti = null;

    private float laskuri = 0f;
    private float kulma = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.laskuri += (Time.deltaTime * 30f);

        this.kulma = this.GetComponent<Transform>().rotation.eulerAngles.z;

        if (this.laskuri >= 15f && this.laskuri <= 30f)
        {
            GameObject apuluoti = Instantiate(this.luoti, new Vector3(5.2f, -0.6f), Quaternion.identity);

            float astekulma = this.kulma * Mathf.Deg2Rad;
            float x1 = Mathf.Cos(astekulma);
            float y1 = Mathf.Sin(astekulma);
            Debug.Log("X=" + x1 + " Y=" + y1);

            apuluoti.GetComponent<Rigidbody2D>().AddForce(new Vector3(x1, y1) * 1000f);
            Destroy(apuluoti.gameObject, 10f);



        }

        if (this.laskuri >= 150f)
        {

            this.laskuri = 0;

        }


    }
}
