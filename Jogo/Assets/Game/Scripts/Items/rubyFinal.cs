using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubyFinal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(10f, 60f), Random.Range(10f, 40f)),ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 8){
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
