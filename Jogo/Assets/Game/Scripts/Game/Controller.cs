using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public static Controller Instancia;
    public int points;
    void Start()
    {  
        Instancia = this;
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
