using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pommi_isku : MonoBehaviour {

    public GameObject pommi = null;

    private float laskuri = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.laskuri += (Time.deltaTime * 30f);

        if (this.laskuri >= 30f && this.laskuri <= 31.5f)
        {
            GameObject apupommi = Instantiate(this.pommi, new Vector3(Random.Range(-8f, 3.5f), Random.Range(8f, 15f), 0f), Quaternion.identity);
            


        }

        if(this.laskuri >= 150f)
        {

            this.laskuri = 0;

        }



       

	}
}
