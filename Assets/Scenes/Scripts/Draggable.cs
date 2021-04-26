using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    void OnMouseDrag() {
        float DistanciaZ = 9.26f;
        Vector3 PosicaoMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, DistanciaZ);
        Vector3 PosicaoRelativa = Camera.main.ScreenToWorldPoint(PosicaoMouse); 
        transform.position = PosicaoRelativa;    
    }
}
