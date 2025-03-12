using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class CobolDeath : MonoBehaviour
{
    public GameObject Rubys;
    public GameObject caamera;
    public GameObject MusicadeFundo;

    void Update()
    {
        if(Controller.Instancia.Cobol == false){
             Rubys.SetActive(true);

             StartCoroutine(Cutscene());
        }
    }
    IEnumerator Cutscene(){
        yield return new WaitForSeconds(10f);
        MusicadeFundo.GetComponent<AudioSource>().Stop();
        caamera.GetComponent<VideoPlayer>().Play();
        yield return new WaitForSeconds(23f);
        Controller.Instancia.MudarFase("Menu");
        
    }
  
}
