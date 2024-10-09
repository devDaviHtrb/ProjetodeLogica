using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Tiro : MonoBehaviour
{


    public Vector3 movement;
    public GameObject jogador;

    // Start is called before the first frame update
    void Start()
    {

        transform.eulerAngles = jogador.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
             transform.Translate(Vector2.right*10f*Time.deltaTime);
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Inimigo"){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>


}
