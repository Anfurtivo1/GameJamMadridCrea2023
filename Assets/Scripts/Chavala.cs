using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chavala : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (!pauseManager.GetComponent<PauseManager>().paused)
        //{
        //    if (currentSpeed < maxSpeed)
        //    {
        //        currentSpeed += SpeedMultiplier;
        //    }
        //}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            
            Time.timeScale = 0f;
            //botonReiniciar.SetActive(true);
            //botonMenuprincipal.SetActive(true);
            //imagenPerder.SetActive(true);

        }
    }

}
