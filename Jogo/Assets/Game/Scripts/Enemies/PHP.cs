using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHP : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public float Limite;
    public float speed;
    public bool correndo = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Player.transform.position.x - gameObject.transform.position.x;
        if (distancia<0){
            distancia *=-1;
        }
        if(distancia<=Limite){
            correndo = true;
        }
        if(correndo == true){
            if(Player.transform.position.x >= gameObject.transform.position.x){
                gameObject.transform.position += new Vector3(speed, 0f, 0f);
            }else{
                gameObject.transform.position += new Vector3(-speed, 0f, 0f);
            }
        }

        if(Player.transform.position.x >=gameObject.transform.position.x){
            gameObject.transform.eulerAngles = new Vector3(0f, 180f, 0);
        }else{
            gameObject.transform.eulerAngles = new Vector3(0f, 0f, 0);
        }
    }
}
