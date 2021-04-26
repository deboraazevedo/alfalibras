using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestaColisao : MonoBehaviour
{
    public int idPalavra;
    public Sprite imgCorreta;


    void OnTriggerEnter2D(Collider2D colisor){
        int idOutraPeca = colisor.gameObject.GetComponent<TestaColisao>().idPalavra;
        if (idOutraPeca == idPalavra) {
            transform.GetComponent<SpriteRenderer>().sprite = imgCorreta;
            transform.GetComponent<Draggable>().enabled = false;
            transform.GetComponent<BoxCollider2D>().enabled = false;
            //colisor.transform.position.y = this.transform.position.y;
            
        }

    
    }
        
}
