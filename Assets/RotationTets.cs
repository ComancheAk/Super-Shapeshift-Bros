using UnityEngine;
using System.Collections;

public class RotationTets : MonoBehaviour {
    public float force = 50f;
    public Rigidbody2D rb2d;
    public int Player = 0;
    //public bool moreThanOneGamePad;
    //public bool assholeMode;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void FixedUpdate()
    {
        if (Player == 0)
        {
            rb2d.AddTorque(-force * Input.GetAxis("Horizontal_P1"));
        }
        if (Player == 1)
        {
            rb2d.AddTorque(-force * Input.GetAxis("Horizontal_P2"));
        }

    }
}
