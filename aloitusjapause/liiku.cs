using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class liiku : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator animaatio;

    private float maxnopeus = 3f;
    private float juoksu = 7f;
    private float liikey = 0f;
    private bool oikealle = true;
    public CapsuleCollider2D kapseli;
   

    bool onkomaassa = false;
    float maassaleveys = 0.02f;
    public Transform maassa;
    public LayerMask maa;
    private float hyppy =800f;
    public pistelasku pisteet1;
    public AudioSource tidudii;
    public float ajastin = 0f;
    public bool voltti = true;
    
   


    void Start()
    {
       

        kapseli = kapseli.GetComponent<CapsuleCollider2D>();
        tidudii = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        animaatio = GetComponent<Animator>();
        pisteet1 = GameObject.FindGameObjectWithTag("pistelasku").GetComponent<pistelasku>();
       

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        onkomaassa = Physics2D.OverlapCircle(maassa.position, maassaleveys, maa);
        animaatio.SetBool("maassa", onkomaassa);



        float liiku = Input.GetAxis("Horizontal");
        animaatio.SetFloat("nopeus", Mathf.Abs(liiku));

        if (onkomaassa == true)
        {
            rb.velocity = new Vector2(liiku * maxnopeus, rb.velocity.y);
            
        }
        if (onkomaassa == false && Input.GetKey(KeyCode.A) && rb.velocity.x > -4f)
        {
            rb.velocity = new Vector2(rb.velocity.x - 0.4f, rb.velocity.y);

        }
        if (onkomaassa == false && Input.GetKey(KeyCode.D) && rb.velocity.x < 4f)
        {
            rb.velocity = new Vector2(rb.velocity.x + 0.4f, rb.velocity.y);

        }


        if (Input.GetKey(KeyCode.LeftShift) && onkomaassa == true && liiku != 0)
        {
            rb.velocity = new Vector2(liiku * juoksu, rb.velocity.y);

            animaatio.SetBool("juoksu", true);
        }
        else
        {
            animaatio.SetBool("juoksu", false);

        }





        Vector2 liike = new Vector2(liikey, liiku);

        rb.AddForce(liike * maxnopeus);
        if (liiku > 0 && !oikealle)
        {
            kaanna();
        }
        else if (liiku < 0 && oikealle)
        {
            kaanna();
        }
        if (transform.position.x >= 120f)
        {
            rb.position = new Vector3(-360.0f, rb.position.y, 0.0f);
        }
        if (transform.position.x <= -360.0f)
        {
            rb.position = new Vector3(120f, rb.position.y, 0.0f);
        }



    }

    void Update()
    {

      
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            voltti = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            voltti = false;
        }
        float liiku = Input.GetAxis("Horizontal");
        if (onkomaassa == true && Input.GetKeyDown(KeyCode.Space)&& ajastin > 0.5f)
        {

            animaatio.SetBool("maassa", false);
            rb.AddForce(new Vector2(0, hyppy));
        }
        if (onkomaassa == true && Input.GetKeyDown(KeyCode.Space) && ajastin < 0.5f && liiku >0)
        {

            animaatio.SetBool("maassa", false);
            rb.AddForce(new Vector2(400f, hyppy));
            animaatio.SetBool("laskeutuminen", false);
            

        }
        if (onkomaassa == true && Input.GetKeyDown(KeyCode.Space) && ajastin < 0.5f && liiku < 0)
        {

            animaatio.SetBool("maassa", false);
            rb.AddForce(new Vector2(-400f, hyppy));
            animaatio.SetBool("laskeutuminen", false);
            

        }

        if (pisteet1.pisteet >= 15)
        {
            hyppya();
        }
        if(onkomaassa == true)
        {
            ajastin = ajastin +0.05f;
            voltti = false;
            animaatio.SetBool("voltti", false);


        }
        if (onkomaassa == true && ajastin < 0.5f)
        {
            animaatio.SetBool("laskeutuminen", true);
            animaatio.SetBool("voltti", false);


        }
        if (onkomaassa == false)
        {
            ajastin = 0f;
            animaatio.SetBool("laskeutuminen", false);

        }
        if(ajastin >= 0.5f)
        {
            animaatio.SetBool("laskeutuminen", false);
        }
        if (voltti == true)
        {
            animaatio.SetBool("voltti", true);
           kapseli.size = new Vector3(0.14f, 0.24f,0f);
            kapseli.offset = new Vector3(-0.00453373f, 0.004f, 0f);
            maassa.position = new Vector2(rb.position.x, rb.position.y - 1.066f);


        }
        if (voltti == false)
        {
            animaatio.SetBool("voltti", false);
           kapseli.size = new Vector3(0.14f, 0.43f,0f);
            kapseli.offset = new Vector3(-0.0045337f, -0.1375229f, 0f);
           maassa.position = new Vector2(rb.position.x, rb.position.y -3f);
        }

    }
    void kaanna()
    {
        oikealle = !oikealle;
        Vector3 kaanto = transform.localScale;
        kaanto.x *= -1;
        transform.localScale = kaanto;



    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("pallo"))
        {
            
            Destroy(col.gameObject);
            pisteet1.pisteet += 1;
            tidudii.Play();
            
           
        }


    }
    void hyppya (){
        hyppy = 1500f;
      
    }


}