
using UnityEngine;


public class spike : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.layer == 7 || other.gameObject.layer == 8 || other.gameObject.tag == "Player" || other.gameObject.layer == 9 || other.gameObject.tag == "Espinho")
        {
            Destroy(gameObject);
        }
    }
}
