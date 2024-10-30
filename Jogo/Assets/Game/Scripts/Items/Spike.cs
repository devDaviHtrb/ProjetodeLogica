using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spike : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.layer == 7 || other.gameObject.layer == 8 || other.gameObject.tag == "Player" || other.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
    }
}
