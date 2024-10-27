using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour

    
{
    public AudioSource Audio;
    public AudioClip[] clipes;
    // Start is called before the first frame update
    void Start()
    {
        Audio = gameObject.GetComponent<AudioSource>();
        System.Random rnd = new System.Random();
        Audio.clip = clipes[rnd.Next(2)];
        Audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
