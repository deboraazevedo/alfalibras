using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorteio : MonoBehaviour
{
    public GameObject[] objetos;
    public GameObject[] objetosVisiveis;

    private Vector3[] posicoes = new Vector3[10];
    
    void Start()
    {
        Vector3 inicial = new Vector3(-5.9f, 9.6f, 9.7f);
        for(int i=0; i<10; i++) {
            float x = objetosVisiveis[i].transform.position.x;
            float y = objetosVisiveis[i].transform.position.y;
            float z = objetosVisiveis[i].transform.position.z;
            posicoes[i] = new Vector3(x, y, z);
            objetosVisiveis[i].transform.position = inicial;
        }
    
        for(int i=0; i<10; i+=2) {
            int letra = SortearLetra(i, i+1);
            int[] filhos = Sortear();
            for(int j=i, filho=0; j<i+2; j++, filho++) {
                objetos[letra].transform.GetChild(filhos[filho]).transform.position = posicoes[j];
            }   
            
        }
    }

    int SortearLetra(int min, int max) { return Random.Range(min,max+1);}

    int[] Sortear() {
        int num1 = 0;
        int num2 = 0;
        do{
            num1 = Random.Range(0,4);
            num2 = Random.Range(0,4);

        } while(num1==num2);

        return new int[] {num1, num2};

    }
}
