using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    public static bool isOnePlayerGame = true;

    public void OnClickPlay()
    {

        GameBoard.playerOneLevel = 1;
        GameBoard.playerOneScore = 0;
        GameBoard.livesPlayerOne = 3;
        print("Play button is working.\n Proceeds to the game.");
        SceneManager.LoadScene(1);

    }

    public void OnClickQuit()
    {
        print("Quit button is working.\n Proceeds to exiting the game.");
        Application.Quit();
    }

}

