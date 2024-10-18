using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] hearts = new Sprite[] {};

    void Update()
    {
        gameObject.GetComponent<Image>().sprite = hearts[Controller.Instancia.vida];
    }
}
