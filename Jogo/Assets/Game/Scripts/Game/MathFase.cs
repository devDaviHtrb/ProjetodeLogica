
using UnityEngine;


public class MathFase : MonoBehaviour
{
    public int cont = 0;
    public GameObject[] Fases = new GameObject[] {};
    public int np = 0;
    public GameObject Anim;
    // Start is called before the first frame update
    public void correta(){
        Fases[cont].SetActive(false);
        Fases[cont+1].SetActive(true);
        cont++;
    }
    public void error(){
        Fases[cont].SetActive(false);
        Anim.GetComponent<Animator>().SetBool("Error", true);
        Destroy(gameObject);
    }
    public void errada(GameObject button){
        Destroy(button);
    }

}
