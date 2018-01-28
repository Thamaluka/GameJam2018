using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Transform Ship;
    public Transform Walls;
    public Transform Waves;
    public Transform Spawn;

    public int Points;
    public Text Score;
  
	// Use this for initialization
	void Start () {
        Points = 0;
        Instantiate(Ship, Ship.transform.position, Ship.transform.rotation);
        Instantiate(Walls, Walls.transform.position, Walls.transform.rotation);
        Instantiate(Waves, Waves.transform.position, Waves.transform.rotation);
        Instantiate(Spawn, Spawn.transform.position, Spawn.transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        Score.text = "Score: " + Points.ToString();
        Points++;

    }
}
