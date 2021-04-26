using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoNavegacao : MonoBehaviour
{
    public string NextScene;

    void OnMouseDown(){
        SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
    }
}
