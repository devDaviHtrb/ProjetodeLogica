using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;


public class Player : MonoBehaviour
{  

    public float speed;
    public float jumpF = 14f;
    private bool podepular;
    private bool doublejump;
    public bool TemArma;
    [SerializeField]
    private GameObject tiro;
    public int Vprojetil = 2;
    private Animator anim;

    public AudioSource Audio;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Audio =  GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void Update()
    {
        move();
        if(podepular == true){
            jump();
        }
        if(PlayerPrefs.GetInt("Arma")==1){
            anim.SetBool("TemArma", true);
        }

        Arma();
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
                GetComponent<Rigidbody2D>().velocity = new Vector3(0f, jumpF, 0f);
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

        if(col.gameObject.tag == "Cabeca"){
            Dano();
            Controller.Instancia.vida +=1;
        }
        if(col.gameObject.layer == 9 ){
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
        }
        if(other.gameObject.tag == "ColatevelJava"){
            Controller.Instancia.vida+=1;
            Audio.Play();
        }
        if(other.gameObject.tag == "Arma"){
            TemArma = true;
            PlayerPrefs.SetInt("Arma", 1);
            
    }
     if(other.gameObject.tag == "HitKill"){
            Controller.Instancia.vida = 0;
        }
        if(other.gameObject.layer == 10){
        Controller.Instancia.vida -=1;
        Destroy(other.gameObject);
    }
    }
    

}
