using UnityEngine;
using System.Collections;

public class PressStart : MonoBehaviour {
    public float pingPong;
    public GameObject faces;
    public GameObject copyright;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        pingPong = Mathf.PingPong(Time.time, 0.75f);
        if (pingPong < 0.425f)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        } else { gameObject.GetComponent<Renderer>().enabled = true; }
        if (Input.GetButton("Start"))
        {
            if (faces != null) {

                faces.GetComponent<FaceMoving>().firstStartPressed = true;
                gameObject.SetActive(false);

            }
            if (copyright != null)
            {

                
                copyright.SetActive(false);

            }
        }
        if (Input.GetButtonDown("Back"))
        {
            Application.Quit();
        }

	}
}
