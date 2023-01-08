# DODING-NINJAA
This is my first trying to a video games.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.SceneManagement;
public class Canbar : MonoBehaviour
{
    public GameObject canbar;
    public float can;
    public float hak = 9.0f;
    public Hareket Hareket;
    void Start()
    {
        can = 100.0f;
    }

    void Update()
    {   if(hak==0)
        {
            Hareket.enabled= false;
            SceneManager.LoadScene(2);
        }
        canbar.transform.localScale = new Vector3(can/100,1,1);
        if(can>= 100)
        {
            can = 100.0f;
        }
        else if(can <=0) 
        {
            can = 0f;
        }

      
    }
    private void OnCollisionEnter(Collision collision) //Eğer sürekli platforma değiyorsa
    {
        if (collision.gameObject.tag == "Player") //eğer platform etiketli nesneye değerse
        {

            canbar.transform.Translate(new Vector3(-48f*Time.deltaTime, 0, 0));
            hak--;


        }

    }
}
    
