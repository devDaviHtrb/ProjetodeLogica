using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobolDeath : MonoBehaviour
{
    public int cont = 0;
    public GameObject Rubys;
    void Update()
    {
        if(Controller.Instancia.Cobol == false && cont <1){
            cont++;
            Rubys.SetActive(true);
            AudioSource Audio = GetComponent<AudioSource>();
            Audio.Play();
        }
    }
}
