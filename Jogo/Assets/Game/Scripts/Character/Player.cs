using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;


public class Player : MonoBehaviour
{  

    public float speed = 5;
    public float jumpF = 6;
    private bool podepular;
    private bool doublejump;
    public bool TemArma;
    [SerializeField]
    private GameObject tiro;
    public int Vprojetil = 2;
    private Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
     anim = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        move();
        if(podepular == true){
            jump();
        }
        Arma();

        Debug.Log("teste");
    }
    void move(){
        Vector3 movement =  new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement *speed;
        if(Input.GetAxis("Horizontal")> 0){
            transform.eulerAngles = new Vector3(0f,0f,0f);
            anim.SetBool("Walk", true);
        }else{
            if(Input.GetAxis("Horizontal")< 0){
                transform.eulerAngles = new Vector3(0f,180f,0f);
                anim.SetBool("Walk", true);
            }else{
                anim.SetBool("Walk", false);
            }
        }

    }
    void jump(){
        if(Input.GetButtonDown("Jump")){
            if(podepular==true){
                anim.SetBool("Jump", true);
                GetComponent<Rigidbody2D>().velocity = new Vector3(0f, transform.position.y, 0f) + new Vector3(0f,14f, 0f);
                if(doublejump==true){
                    podepular = true;
                    doublejump = false;
                }else{
                    podepular=false;
                }
            }
           
        }
    }

    void Dano(){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(3f, 6f), ForceMode2D.Impulse);

    }
    void atirar(){
            Vector2 direcao = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gameObject.transform.position;
            GameObject novotiro = Instantiate(tiro, gameObject.transform.position, Quaternion.identity);
            
            novotiro.GetComponent<Rigidbody2D>().velocity = direcao*Vprojetil;
            anim.SetBool("Shot", false);
    }
    void Arma(){
         if(Input.GetMouseButtonDown(0)){
             anim.SetBool("Shot", true);
         }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.layer == 8){
            podepular = true;
            doublejump= true;
            anim.SetBool("Jump", false);
        }
        if(col.gameObject.tag=="Inimigo"){
            Dano();
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
            Controller.Instancia.UpdateScoreText();
             TemArma = true;
             anim.SetBool("TemArma", true);
        }
        if(other.gameObject.tag == "ColatevelJava"){
            Controller.Instancia.vida+=1;
        }
        if(other.gameObject.tag == "Arma"){
            TemArma = true;
    }
     if(other.gameObject.tag == "HitKill"){
            Controller.Instancia.vida = 0;
        }
    }

}
