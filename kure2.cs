using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kure2 : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    public Collision collision;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, speed);

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "k(Clone)")
        {
            Destroy(gameObject, 4);
        }
    }
    private void OnCollisionEnter(Collision collision) //Eðer sürekli platforma deðiyorsa
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject,-0.1f);
        }
    }
}
