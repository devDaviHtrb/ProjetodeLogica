using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cobol : MonoBehaviour
{
    [SerializeField]
    private GameObject tiro;
    public float Vprojetil = 0.7f;

    [SerializeField]
    private Transform jogador;

    /*Ativado por evento na animação*/
    void atirar(){
            Vector2 direcao = jogador.position - gameObject.transform.position;
            GameObject novotiro = Instantiate(tiro, gameObject.transform.position - new Vector3(0.6f, 0.1f, 0f), Quaternion.identity);
            novotiro.GetComponent<Rigidbody2D>().velocity = direcao* Vprojetil;

    } 
    }


