using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //1. Declaro la variable para el objeto Game Manager
    private GameObject gameManager;
    
    void Start()
    {
        //2. Busco el objeto GameManager en la escena y lo asocio a la variable
        gameManager = GameObject.Find("GameManager");
        
        //3. Le indico que no se destruya entre escenas
        DontDestroyOnLoad(gameManager);
        
        //4. Cargo la siguiente escena (la de Inicio)
        SceneManager.LoadScene("Inicio");

    }
}
