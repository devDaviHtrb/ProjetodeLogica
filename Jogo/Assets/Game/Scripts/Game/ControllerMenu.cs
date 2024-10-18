using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("vida", 4);
        PlayerPrefs.SetInt("points", 0);
    }
    public void Iniciar(string fase){
        SceneManager.LoadScene(fase);
    }
}
