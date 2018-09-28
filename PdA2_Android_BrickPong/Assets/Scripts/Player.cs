using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public KeyCode up;
    public KeyCode down;

    float speed;

	// Use this for initialization
	void Start () {
        speed = 0.3f;
	}
	
	// Update is called once per frame
	/*void Update () {
        if ()
        {
            transform.Translate(0, 1, 0);
        }
        if ()
        {
            transform.Translate(0, -1, 0);
        }
    }*/
}
