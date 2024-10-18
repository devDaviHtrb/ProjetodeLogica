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
    void Start()
    {  
        Instancia = this;
        vida = PlayerPrefs.GetInt("vida");
        points = PlayerPrefs.GetInt("points");
    }

    // Update is called once per frame
    void Update()
    {
        LoadInfo();
        if(vida ==0){
            GameOver.SetActive(true);
            Destroy(Player);
        }
    }
    public void UpdateScoreText(){
        scoreText.text = points.ToString();
    }
    public void Restore(){
        Debug.Log("Funcionou");
        PlayerPrefs.SetInt("vida", 4);
        PlayerPrefs.SetInt("points", 0);
        vida = PlayerPrefs.GetInt("vida");
        points = PlayerPrefs.GetInt("points");
        SceneManager.LoadScene("Fase1");
    }
    public void MudarFase(string fase){
        SceneManager.LoadScene(fase);
    }
    public void LoadInfo(){
        PlayerPrefs.SetInt("points", points);
        PlayerPrefs.SetInt("vida", vida);
        Debug.Log(PlayerPrefs.GetInt("vida"));
    }
}
