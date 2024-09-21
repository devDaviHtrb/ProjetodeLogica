using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public static Controller Instancia;
    public int points;
    public int vida;
    public Text scoreText;
    void Start()
    {  
        Instancia = this;
        points = 0;
        vida = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(vida);
    }
    public void UpdateScoreText(){
        scoreText.text = points.ToString();
    }
}
