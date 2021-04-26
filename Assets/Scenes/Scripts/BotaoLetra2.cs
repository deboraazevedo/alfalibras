using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoLetra2 : MonoBehaviour
{
    public Sprite imagemFruta;
    public GameObject objetoFruta;
    public GameObject videoSinal;
    public int idLetra;
    public string respostaEsperada;
    public InputField textoLimpar;
    public Text erros;

    void OnMouseDown(){
        objetoFruta.GetComponent<SpriteRenderer>().sprite = imagemFruta;
        Animator anima = videoSinal.GetComponent<Animator>();
        anima.SetInteger("ativo", idLetra);
        Gabarito.atv2 = respostaEsperada;
        textoLimpar.text = "";
        erros.text = "";



}
    public void start(){
        Animator anima = videoSinal.GetComponent<Animator>();
        anima.SetInteger("ativo", 0);
    }
}
