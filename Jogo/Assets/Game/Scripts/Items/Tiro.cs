
using UnityEngine;


public class Tiro : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
            
        if(other.gameObject.layer > 5){
            Destroy(gameObject);
        }

    }

}
