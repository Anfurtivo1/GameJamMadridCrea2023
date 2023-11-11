using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5;
    public float hInput;
    public ChavalaManager chavalaManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chavala")
        {
            chavalaManager.GenerateNewWave();
            Destroy(collision.gameObject);
            //Time.timeScale = 0f;
            //botonReiniciar.SetActive(true);
            //botonMenuprincipal.SetActive(true);
            //imagenGanar.SetActive(true);

        }
    }

}
