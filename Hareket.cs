using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Hareket : MonoBehaviour
{
    //DE���KENLER
    public GameObject character;
    Rigidbody rb;
    public float Hiz = 5.0f;
    public float ziplamaGucu = 4.0f;
    public bool yerdeMi; //kontrolcu De�i�ken
   
   

    void Start()
    {
        //Rigidbody Bile�enini tan�mlama ve De�i�kene Atama
        rb = character.GetComponent<Rigidbody>();
    
    }

    // Update is called once per frame
    void Update()
    {
        //W-A-S-D ya Y�n tu�lar�na bas�l�rsa yatay adl� de�i�kene eksene g�re de�er verir.
        float yatay = Input.GetAxis("Horizontal") * Time.deltaTime * Hiz;
        if (character.transform.rotation.eulerAngles.y == 180)
        {
            character.transform.Translate(new Vector3(0, 0, -yatay)); // Y eksenini de�i�tir.

            if (Input.GetKeyDown("space")) //E�er Bo�luk tu�una bas�l�rsa.
            {
                if (yerdeMi) //yerDemi de�i�keni True ise i�erisini ger�ekle�tir.
                {

                    rb.AddForce(new Vector3(0, ziplamaGucu, 0), ForceMode.Impulse);
                }
            }

        }
        else if (character.transform.rotation.eulerAngles.y == 0)
        {
            character.transform.Translate(new Vector3(0, 0, yatay)); // Y eksenini de�i�tir.
            if (Input.GetKeyDown("space")) //E�er Bo�luk tu�una bas�l�rsa.
            {
                if (yerdeMi) //yerDemi de�i�keni True ise i�erisini ger�ekle�tir.
                {

                    rb.AddForce(new Vector3(0, ziplamaGucu, 0), ForceMode.Impulse);
                }
            }

        }
        }
    private void OnCollisionStay(Collision collision) //E�er s�rekli platforma de�iyorsa
    {
        if (collision.gameObject.tag == "platform") //e�er platform etiketli nesneye de�erse
        {
            yerdeMi = true; //yerDemi de�i�keninin de�erini true(do�ru) yap.

        }

    }



        private void OnCollisionExit(Collision collision) // E�er platforma de�me i�lemi bittiyse.
        {
        if (collision.gameObject.tag == "platform") //platform etiketli nesnelere de�miyorsa
            {
            yerdeMi = false; //yerdeMi de�i�keninin de�erini false(yanl��) yap.

            }

        }



}

