
using UnityEngine;
using UnityEngine.SceneManagement;

public class Computer : MonoBehaviour
{

    public void MudarFase(string fase){
        SceneManager.LoadScene(fase);
    }
}
