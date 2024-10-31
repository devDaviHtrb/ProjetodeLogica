
using UnityEngine;


public class Cabeca : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject parent1;
        [SerializeField]
     private GameObject parent2;
    
    void Update()
    {
        gameObject.transform.position = parent1.transform.position;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player"){
            Destroy(parent2);
        }
    }
}
