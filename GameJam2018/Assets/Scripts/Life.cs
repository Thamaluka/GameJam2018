using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Life : MonoBehaviour {
    public Transform lifes;
    public int qntLifes;

    public Image[] rocket = new Image[3];
    public GameObject gameOverPanel;
    
    

	// Use this for initialization
	void Start () {

        qntLifes = 3;
        for (int i=0; i<3; i++)
        {
            rocket[i].enabled = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (qntLifes == 3 && !rocket[2].enabled)
        {
            rocket[2].enabled = true;
        }
        else if (qntLifes == 2 && rocket[2].enabled)
        {
            rocket[2].enabled = false;            
        }
        else if (qntLifes == 1 && rocket[1].enabled)
        {
            rocket[1].enabled = false;
        }
        else if (qntLifes == 2 && !rocket[1].enabled)
        {
            rocket[1].enabled = true;
        }
        else if (qntLifes <= 0 && !rocket[0].enabled)
        {
            rocket[0].enabled = false;
           
        }

        if(qntLifes <= 0)
        {
            for (int i = 0; i < 3; i++)
            {
                rocket[i].enabled = false;
            }
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverPanel.active = true;
    }
}
