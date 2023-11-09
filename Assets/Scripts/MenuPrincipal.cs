using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnIniciar()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    public void btnCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void btnSalir()
    {
        Application.Quit();
    }

}
