
using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string LevelName;
    public AudioSource Audio;
    public AudioClip[] Clipes;

    void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == "Player")
        {
            Audio = GetComponent<AudioSource>();
            System.Random rnd = new System.Random();
            Audio.clip = Clipes[rnd.Next(2)];
            Audio.Play();
            StartCoroutine(Wait(3));
        }
    }
        private IEnumerator Wait(float waitTime){
            yield return new WaitForSeconds(waitTime);
            SceneManager.LoadScene(LevelName);
      }
}
