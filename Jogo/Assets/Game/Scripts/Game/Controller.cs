using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public static Controller Instancia;
    public int points;
    public int vida;
    public Text scoreText;
    public GameObject GameOver;
    public GameObject Player;
    public bool Cobol = true;
    void Start()
    {  
        Instancia = this;
        vida = PlayerPrefs.GetInt("vida");
        points = PlayerPrefs.GetInt("points");
        if(SceneManager.GetActiveScene().name == "Fase1" ||SceneManager.GetActiveScene().name == "Fase2"||SceneManager.GetActiveScene().name == "Menu"||SceneManager.GetActiveScene().name == "MathFase"){
            PlayerPrefs.SetInt("Arma", 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        alterInfo(vida, points);
        if(vida ==0){
            GameOver.SetActive(true);
            Destroy(Player);
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
}
