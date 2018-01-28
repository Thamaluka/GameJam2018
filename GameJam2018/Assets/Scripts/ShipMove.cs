using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{

    public float speed;
    public int life;

    private bool canMoveUp;
    private bool canMoveDown;

    private SpriteRenderer Ship;
    private int count = 0;
    // Use this for initialization
         
void Start()
    {
        canMoveUp = true;
        canMoveDown = true;
        life = 2;
        Ship = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = 10 * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow) && canMoveUp)
        {
            transform.Translate(new Vector3(0, speed, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow) && canMoveDown)
        {
            transform.Translate(new Vector3(0, -speed, 0));
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.name)
        {
            case "WallUp":
                canMoveUp = false;
                break;
            case "WallDown":
                canMoveDown = false;
                break;
        }
    }


    void OnTriggerExit2D(Collider2D col)
    {
        switch (col.gameObject.name)
        {
            case "WallUp":
                canMoveUp = true;
                break;
            case "WallDown":
                canMoveDown = true;
                break;
            case "Obstacles":
              InvokeRepeating("BlinkShip", 0.1f, 0.2f);
              break;
        }

    }


   void  BlinkShip()
    {
      
        if (count < 6)
        {
            
            Ship.enabled = !Ship.enabled;
        }
        else
        {
            count = 0;
            Ship.enabled = true;
            CancelInvoke("BlinkShip");
        }
        count++;
    }

    

}
