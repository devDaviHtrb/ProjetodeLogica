using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Tiro : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
            
        if(other.gameObject.layer > 5){
            Destroy(gameObject);
        }

    }

}
