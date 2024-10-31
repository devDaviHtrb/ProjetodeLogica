
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("vida", 3);
        PlayerPrefs.SetInt("points", 0);
        PlayerPrefs.SetInt("Arma", 0);
    }
    public void Iniciar(string fase){
        SceneManager.LoadScene(fase);
    }
    public void sair(){
        Application.Quit();
    }
}
