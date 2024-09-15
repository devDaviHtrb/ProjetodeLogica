using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{  
    public int vida = 10;
    public float speed = 5;
    public float jumpF = 5;
    private bool podepular;
    private bool doublejump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
        if(podepular == true){
            jump();
        }

    }
    void move(){
        Vector3 movement =  new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement *Time.deltaTime*speed;
    }
    void jump(){
        if(Input.GetButtonDown("Jump") && podepular == true){
           GetComponent<Rigidbody2D>().AddForce( new Vector2(0f, 1f*jumpF), ForceMode2D.Impulse);
           podepular = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.layer == 8){
            podepular = true;
            doublejump= true;
        }
    }
        void OnCollisionExit2D(Collision2D col)
    {
        if(doublejump == true){
            podepular = true;
            doublejump = false;
        }
    }
}
