using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoAcessivel : MonoBehaviour
{
    public Sprite imagemFruta;
    public GameObject objetoFruta;
    public GameObject videoSinal;
    public int idLetra;

    void OnMouseDown(){
        objetoFruta.GetComponent<SpriteRenderer>().sprite = imagemFruta;

        Animator anima = videoSinal.GetComponent<Animator>();
        anima.SetInteger("ativo", idLetra);


}
    public void start(){
        Animator anima = videoSinal.GetComponent<Animator>();
        anima.SetInteger("ativo", 0);
    }
}
