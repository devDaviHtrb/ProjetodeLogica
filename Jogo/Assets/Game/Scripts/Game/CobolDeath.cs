using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobolDeath : MonoBehaviour
{

    public int cont = 0;
    void Start()
    {

    }

    void Update()
    {
        if(Controller.Instancia.Cobol == false && cont <1){
            cont++;
            AudioSource Audio = GetComponent<AudioSource>();
            Audio.Play();
        }
    }
}
