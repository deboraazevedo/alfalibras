using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEffect : MonoBehaviour
{
    public Sprite mouseHover;
    public Sprite mouseExit;

    void OnMouseOver(){
        transform.GetComponent<SpriteRenderer>().sprite = mouseHover;    
    }

    void OnMouseExit(){
        transform.GetComponent<SpriteRenderer>().sprite = mouseExit;    
    }   
}
