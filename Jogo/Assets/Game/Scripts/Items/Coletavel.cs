using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    private bool coletado;
    // Start is called before the first frame update
    void Start()
    {
        coletado = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnTriggerEnter2D(Collider2D other)
    {
            if(coletado == false && other.tag == "Player"){
                Debug.Log("Foi coletado");
                Destroy(gameObject);
        }
    }
}
