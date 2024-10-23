using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawnspike : MonoBehaviour
{
    // Start is called before the first frame update

    public bool esquerda;
    public bool direita;
    public bool cima;
    public bool baixo;

    [SerializeField]
    private GameObject espinho;
    [SerializeField]
    private float distancia;
    
    public float velocidade;
    void Start()
    {
        spawnEspinho();
    }

    private void spawnEspinho(){
        GameObject newSpike = Instantiate(espinho, transform.position, Quaternion.identity);
        moverEspinho(newSpike);
        StartCoroutine(Wait(5));
    }
    public void moverEspinho(GameObject spike){
        if(direita){
            spike.GetComponent<Rigidbody2D>().velocity = new Vector2(distancia*velocidade, 0f);
        }else{
            if(esquerda){
                spike.GetComponent<Rigidbody2D>().velocity = new Vector2(-distancia*velocidade, 0f );
            }
            else{
                if(cima){
                     spike.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, distancia*velocidade );
                }else{
                    if(baixo){
                        spike.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -distancia*velocidade );
                    }
                }
            }
        }
       
    }
    private IEnumerator Wait(float waitTime){
            yield return new WaitForSeconds(waitTime);
            Debug.Log("Atirando");
            spawnEspinho();
      }
}
