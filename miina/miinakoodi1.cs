using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miinakoodi1 : MonoBehaviour {


    public GameObject osuma = null;



    // Update is called once per frame
    void Update()
    {



        

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("pommi2(Clone)"))
        {

            GameObject apuRajahdys = Instantiate(this.osuma, this.GetComponent<Transform>().position, Quaternion.identity);
            Destroy(apuRajahdys.gameObject, 0.25f);
            Destroy(this.gameObject);

        }
    } 
}
