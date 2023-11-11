using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class ChavalaManager : MonoBehaviour
{
    public GameObject chavala;
    public Rigidbody2D rb;
    float mass;
    // Start is called before the first frame update
    void Start()
    {
        GenerateChavala();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateChavala()
    {
        int randomNumber = Random.Range(-9, 10);
        Vector2 posicion;
        posicion = new Vector2(randomNumber, 4f);
        GameObject newChavala;
        newChavala = Instantiate(chavala, posicion, transform.rotation);
        newChavala.GetComponent<Rigidbody2D>().mass = rb.mass;
    }

    public void GenerateNewWave()
    {
        float timeBetween = Random.Range(1f, 2f);
        Debug.Log("Tiempo de CD de la chavala: "+timeBetween);
        rb.mass = rb.mass +0.01f;
        rb.gravityScale = rb.gravityScale + 0.01f;
        if (rb.mass >=1.5f || rb.gravityScale >= 1.5f)
        {
            rb.mass = 1.5f;
            rb.gravityScale = 1.5f;
        }
        //Invoke("generateChavala", timeBetween);
        GenerateChavala();
    }

}
