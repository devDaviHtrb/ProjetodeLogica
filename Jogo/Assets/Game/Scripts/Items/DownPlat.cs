using System.Collections;

using UnityEngine;
using UnityEngine.Tilemaps;

public class DownPlat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void Caindo(){
        StartCoroutine(Cair());
    }
    IEnumerator Cair(){
        yield return new WaitForSeconds(0.5f);
        gameObject.AddComponent<Rigidbody2D>();
        Destroy(gameObject.GetComponent<TilemapCollider2D>());
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
  
    void OnCollisionEnter2D(Collision2D other)
    {
       if( other.gameObject.tag == "Player"){
        Caindo();
       }
    }
}
