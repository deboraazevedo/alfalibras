using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NavegaNome : BotaoNavegacao
{
    public Text nome;

    void OnMouseDown(){
        Usuario.nome = nome.text;
        SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
    }

}
