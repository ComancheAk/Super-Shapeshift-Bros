using UnityEngine;
using System.Collections;

public class FaceMoving : MonoBehaviour {
    public GameObject modeSelect;
    public Vector3 moveTo;
    public bool firstStartPressed;
    public bool hited;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (firstStartPressed)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,moveTo,step);
        }
    


        /*
        if (transform.position == moveTo)
        {
            hited = false;
        }
        */
	}

    void FixedUpdate()
    {
        if (transform.position == moveTo)
        {
            //if (modeSelect != null)
            // {
            //modeSelect.SetActive(true);
            hited = true;
            
            // }

        }
        if (hited)
        {
            modeSelect.SetActive(true);
            hited = false;
            gameObject.GetComponent<FaceMoving>().enabled = false;
        }
    }
}
