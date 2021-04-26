using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoLetra1 : MonoBehaviour
{
    public Sprite imagemAnimal;
    public GameObject objetoAnimal;
    public string respostaEsperada;
    public InputField textoLimpar;
    public Text erros;


    void OnMouseDown(){
        objetoAnimal.GetComponent<SpriteRenderer>().sprite = imagemAnimal;
        Gabarito.atv1 = respostaEsperada;
        textoLimpar.text = "";
        erros.text = "";

    }
}
