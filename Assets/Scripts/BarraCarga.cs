using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraCarga : MonoBehaviour
{
    [SerializeField]
    private Image imagen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (imagen.fillAmount > 0)
        {
            imagen.fillAmount = imagen.fillAmount - Time.deltaTime / 10;
        }
    }
}
