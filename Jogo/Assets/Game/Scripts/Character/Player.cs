using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;


public class Player : MonoBehaviour
{  

    public int vida = 10;
    public float speed = 5;
    public float jumpF = 10;
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
        if(Input.GetAxis("Horizontal")> 0){
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }else{
            if(Input.GetAxis("Horizontal")< 0){
                transform.eulerAngles = new Vector3(0f,180f,0f);
            }else{

            }
        }

    }
    void jump(){
        if(Input.GetButtonDown("Jump")){
            if(podepular==true){
                 GetComponent<Rigidbody2D>().AddForce( new Vector2(0f, 1f*jumpF), ForceMode2D.Impulse);
                if(doublejump==true){
                    podepular = true;
                    doublejump = false;
                }else{
                    podepular=false;
                }
            }
           
        }
    }
    void Dano(int dano){
        vida -= dano;
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(3f, 6f), ForceMode2D.Impulse);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.layer == 8){
            podepular = true;
            doublejump= true;
            
        }
        if(col.gameObject.tag=="Inimigo"){
            Dano(1);
            Controller.Instancia.vida -=1;
            if(Controller.Instancia.points != 0){
            Controller.Instancia.points -= 5;
            Controller.Instancia.UpdateScoreText();
            }
           
        }

    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Coletavel"){
            Controller.Instancia.points+=10;
            Debug.Log(Controller.Instancia.points);

            Controller.Instancia.UpdateScoreText();
        }

    }

}
