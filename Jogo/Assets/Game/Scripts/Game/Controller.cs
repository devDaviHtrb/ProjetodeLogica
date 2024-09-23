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
        points = 0;
        vida = 4;
    }

    // Update is called once per frame
    void Update()
    {
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
        SceneManager.LoadScene("SampleTeste");
    }
    public void MudarFase(string fase){
        Debug.Log("Funcionou");
        SceneManager.LoadScene(fase);
    }
}
