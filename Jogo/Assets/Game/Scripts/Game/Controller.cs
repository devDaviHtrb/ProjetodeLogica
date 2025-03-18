using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
public class Controller : MonoBehaviour
{
    public static Controller Instancia;
    public int points;
    public int vida;
    public Text scoreText;
    public GameObject GameOver;
    public GameObject Player;
    public bool Cobol = true;
    public int temp;
    public Text tempoTexto;
    void Start()
    {  
        Instancia = this;
        vida = PlayerPrefs.GetInt("vida");
        points = PlayerPrefs.GetInt("points");

        if(SceneManager.GetActiveScene().name == "Fase2"||SceneManager.GetActiveScene().name == "Menu"||SceneManager.GetActiveScene().name == "MathFase"){
            PlayerPrefs.SetInt("Arma", 0);
        }else{
            PlayerPrefs.SetInt("Arma", 1);
        }
          if(SceneManager.GetActiveScene().name == "Fase1"){
            PlayerPrefs.SetInt("Tempo", 0);
          }
          StartCoroutine(tempo());
    }
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Fase1"){
             PlayerPrefs.SetInt("Arma", 0);
         }
        alterInfo(vida, points);
        if(vida <=0){
            GameOver.SetActive(true);
            Destroy(Player);
        }
        if(Input.GetKeyDown(KeyCode.Z)){
            MudarFase("Fase1");
        }
        if(Input.GetKeyDown(KeyCode.X)){
            MudarFase("Fase2");
        }
        if(Input.GetKeyDown(KeyCode.C)){
           MudarFase("Fase3");
            
        }
        if(Input.GetKeyDown(KeyCode.V)){
            MudarFase("Fase4");
            
        }
        if(Input.GetKeyDown(KeyCode.B)){
            MudarFase("Final");
           
        }
        
    }
    
    public void UpdateScoreText(){
        scoreText.text = points.ToString();
    }
    public void alterInfo(int vida, int points){
        PlayerPrefs.SetInt("vida", vida);
        PlayerPrefs.SetInt("points", points);
    }
    public void Restore(){
        alterInfo(3, 0);
        vida = PlayerPrefs.GetInt("vida");
        points = PlayerPrefs.GetInt("points");
        SceneManager.LoadScene("Fase1");
    }
    public void MudarFase(string fase){
        SceneManager.LoadScene(fase);
    }

    private IEnumerator tempo(){
        yield return new WaitForSeconds(1);
        if(Cobol == true){
             temp = PlayerPrefs.GetInt("Tempo");
             temp++;
             PlayerPrefs.SetInt("Tempo", temp);
            tempoTexto.text = temp.ToString();
        }
        StartCoroutine(tempo());
      }
}


