using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    public int vida;

    // Start is called before the first frame update
    void Start()
    {
       
        if(gameObject.tag == "PHP"){
            vida = 5;
        }else{
            if(gameObject.tag == "Python"){
                vida = 1;
            }else{
                if(gameObject.tag == "Rust"){
                    vida = 2;
                }
                else
                {
                    if(gameObject.tag == "Cobol"){
                        vida = 25;
                    }
                }
            }
        }
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
        if(vida == 0){
            
            if(gameObject.tag == "Cobol"){
                Controller.Instancia.Cobol = false;
                Debug.Log("Morto");
            }
            Destroy(gameObject);
        }  

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Check"){
            dir *=-1f;
            Debug.Log("Virando");
        }
        if(other.gameObject.tag == "Tiro"){
            vida -=1;
            Destroy(other);
        }
    }
}
