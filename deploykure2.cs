using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deploykure2 : MonoBehaviour
{

    public GameObject kurePrefab;
    public float respawnTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(kureWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(kurePrefab) as GameObject;
        a.transform.position = new Vector3(0, 1.07f, -10);
        GameObject b = Instantiate(kurePrefab) as GameObject;
        b.transform.position = new Vector3(0, (float)1.67f, -10);
        GameObject c = Instantiate(kurePrefab) as GameObject;
        c.transform.position = new Vector3(0, 2.12f, -10);
    }
    IEnumerator kureWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Sphere(1)(Clone)")
        {
            Destroy(gameObject, 1);
        }
    }
}