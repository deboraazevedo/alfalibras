using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotaoVerificar : MonoBehaviour
{
    public bool atv1;
    public bool atv2;
    public Text inputResposta;
    private string gabarito = "";
    public Text erros;
    public string telaAcerto;

    void OnMouseDown(){
        if (atv1) {
            gabarito = Gabarito.atv1;
        }
        if (atv2){
            gabarito = Gabarito.atv2;
        }
        CorrigirAtividade();
    }
    void CorrigirAtividade(){
        string [] respostas = gabarito.Split(';');
        foreach(string resposta in respostas) {
            if (inputResposta.text.ToUpper() == resposta.ToUpper()) { 
                erros.text = "";
                SceneManager.LoadScene(telaAcerto, LoadSceneMode.Single);
            
            }
            else {
                erros.text+=inputResposta.text+"\n";
            }
        }
    }
}
