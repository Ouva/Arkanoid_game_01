using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    private int finId1 = -1; //id finger for cancel touch event
    private int finId2 = -1;

    public float moveSpeed = 300;
    public GameObject player;

    private Rigidbody playerBody;
    private float ScreenWidth;

    void Start()
    {
        ScreenWidth = Screen.width;
        playerBody = player.GetComponent<Rigidbody>();
        Input.multiTouchEnabled = true; //enabled Multitouch
    }

    void Update()
    {

        //First check count of touch
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                //For left half screen
                if (touch.phase == TouchPhase.Began && touch.position.x <= Screen.width && finId1 == -1)
                {
                    RunCharacter(1.0f);
                    //Do something: start other function
                    finId1 = touch.fingerId; //store Id finger
                }
                //For right half screen
                if (touch.phase == TouchPhase.Began && touch.position.x > Screen.width && finId2 == -1)
                {
                    //Do something
                    finId2 = touch.fingerId;
                }
                if (touch.phase == TouchPhase.Ended)
                { //correct end of touch
                    if (touch.fingerId == finId1)
                    { //check id finger for end touch
                        finId1 = -1;
                    }
                    else if (touch.fingerId == finId2)
                    {
                        finId2 = -1;
                    }
                }
            }
        }
    }
    private void RunCharacter(float horizontalInput)
    {
        playerBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
    }
}
