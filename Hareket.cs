using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Hareket : MonoBehaviour
{
    //DEÐÝÞKENLER
    public GameObject character;
    Rigidbody rb;
    public float Hiz = 5.0f;
    public float ziplamaGucu = 4.0f;
    public bool yerdeMi; //kontrolcu Deðiþken
   
   

    void Start()
    {
        //Rigidbody Bileþenini tanýmlama ve Deðiþkene Atama
        rb = character.GetComponent<Rigidbody>();
    
    }

    // Update is called once per frame
    void Update()
    {
        //W-A-S-D ya Yön tuþlarýna basýlýrsa yatay adlý deðiþkene eksene göre deðer verir.
        float yatay = Input.GetAxis("Horizontal") * Time.deltaTime * Hiz;
        if (character.transform.rotation.eulerAngles.y == 180)
        {
            character.transform.Translate(new Vector3(0, 0, -yatay)); // Y eksenini deðiþtir.

            if (Input.GetKeyDown("space")) //Eðer Boþluk tuþuna basýlýrsa.
            {
                if (yerdeMi) //yerDemi deðiþkeni True ise içerisini gerçekleþtir.
                {

                    rb.AddForce(new Vector3(0, ziplamaGucu, 0), ForceMode.Impulse);
                }
            }

        }
        else if (character.transform.rotation.eulerAngles.y == 0)
        {
            character.transform.Translate(new Vector3(0, 0, yatay)); // Y eksenini deðiþtir.
            if (Input.GetKeyDown("space")) //Eðer Boþluk tuþuna basýlýrsa.
            {
                if (yerdeMi) //yerDemi deðiþkeni True ise içerisini gerçekleþtir.
                {

                    rb.AddForce(new Vector3(0, ziplamaGucu, 0), ForceMode.Impulse);
                }
            }

        }
        }
    private void OnCollisionStay(Collision collision) //Eðer sürekli platforma deðiyorsa
    {
        if (collision.gameObject.tag == "platform") //eðer platform etiketli nesneye deðerse
        {
            yerdeMi = true; //yerDemi deðiþkeninin deðerini true(doðru) yap.

        }

    }



        private void OnCollisionExit(Collision collision) // Eðer platforma deðme iþlemi bittiyse.
        {
        if (collision.gameObject.tag == "platform") //platform etiketli nesnelere deðmiyorsa
            {
            yerdeMi = false; //yerdeMi deðiþkeninin deðerini false(yanlýþ) yap.

            }

        }



}

