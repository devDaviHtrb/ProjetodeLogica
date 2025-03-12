
using UnityEngine;


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

}
