
using UnityEngine;

public class Coletavel : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
            if(other.tag == "Player"){
                Debug.Log("Foi coletado");
                Destroy(gameObject);
        }
    }
}
