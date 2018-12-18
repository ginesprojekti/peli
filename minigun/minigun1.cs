using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigun1 : MonoBehaviour
{

    public GameObject luoti1 = null;

    private float laskuri = 0f;
    private float kulma = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        this.laskuri += (Time.deltaTime * 30f);

        this.kulma = this.GetComponent<Transform>().rotation.eulerAngles.z;

        if (this.laskuri >= 50f && this.laskuri <= 60f)
        {
            GameObject apuluoti1 = Instantiate(this.luoti1, new Vector3(3.5f, -2.2f), Quaternion.identity);

            float astekulma = this.kulma * Mathf.Deg2Rad;
            float x1 = Mathf.Cos(astekulma);
            float y1 = Mathf.Sin(astekulma);
            Debug.Log("X=" + x1 + " Y=" + y1);

            apuluoti1.GetComponent<Rigidbody2D>().AddForce(new Vector3(x1, y1) * 0.5f);
            Destroy(apuluoti1.gameObject, 10f);



        }

        if (this.laskuri >= 150f)
        {

            this.laskuri = 0;

        }


    }
}
