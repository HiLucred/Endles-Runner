using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void ButtonToStartTheGame()
    {
        //Inicia o jogo
        SceneManager.LoadScene("Level 01");
    }

    public void ButtonToExitTheGame()
    {
        //Fecha o jogo
        Application.Quit();
    }

    public void ButtonToRestartTheGame()
    {
        //Reinicia o jogo
        SceneManager.LoadScene("Level 01");
    }
}