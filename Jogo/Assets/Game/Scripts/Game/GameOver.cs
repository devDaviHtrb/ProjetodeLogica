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
