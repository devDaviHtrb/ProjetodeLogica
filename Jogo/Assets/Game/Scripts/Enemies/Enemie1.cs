using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemie1 : MonoBehaviour
{
    public float dir = 1f;
    public float dist;
    public float cont = 0;
    public bool SeMove;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(SeMove == true){
            if(dir>0){
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }else{
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
            transform.Translate(Vector2.right*-1*Time.deltaTime);
        }
        
            

    }
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Check"){
            dir *=-1f;
            Debug.Log("Mudando");
        }
    }

}
