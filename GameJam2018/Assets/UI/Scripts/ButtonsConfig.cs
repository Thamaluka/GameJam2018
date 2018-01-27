using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsConfig : MonoBehaviour {

    public void GoToIntro()
    {
        Application.LoadLevel("Intro");
    }

    public void GameStart()
    {
        Application.LoadLevel("GamePlay");
    }

    public void ReturnToMenu()
    {
        Application.LoadLevel("Menu");
    }
}
