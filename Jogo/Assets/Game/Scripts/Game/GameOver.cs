using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour

    
{

    // Start is called before the first frame update
    void Start()
    {

    }
    public void Restore(){
        PlayerPrefs.SetInt("vida", 4);
        PlayerPrefs.SetInt("points", 0);
        Controller.Instancia.vida = PlayerPrefs.GetInt("vida");
        Controller.Instancia.points = PlayerPrefs.GetInt("points");
        SceneManager.LoadScene("Fase");
    }
    public void menu(){
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
