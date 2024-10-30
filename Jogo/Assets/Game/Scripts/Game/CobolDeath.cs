using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CobolDeath : MonoBehaviour
{
    public GameObject Rubys;
    public GameObject caamera;

    void Start()
    {
       
    }
    void Update()
    {
        if(Controller.Instancia.Cobol == false){
             Rubys.SetActive(true);
             StartCoroutine(Cutscene());
        }
    }
    IEnumerator Cutscene(){
        yield return new WaitForSeconds(10f);
        caamera.GetComponent<VideoPlayer>().Play();
        yield return new WaitForSeconds(23f);
        Controller.Instancia.MudarFase("Menu");
        
    }
  
}
