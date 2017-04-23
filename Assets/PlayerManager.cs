using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    public int playerNum;
    //public int kidSquid;
    public Vector3 currPlayerPos;
    public Quaternion currPlayerRot;
    public GameObject triangle;
    public GameObject square;
    //public bool oneGamepad;
   // public bool asshole;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {   

            if (playerNum == 0)
            {
                if (Input.GetButtonDown("Select_P1_Asshole"))
                {
                    triangle.SetActive(false);
                    square.SetActive(true);
                    square.transform.position = currPlayerPos;
                    square.transform.rotation = currPlayerRot;
                }
                if (Input.GetButtonUp("Select_P1_Asshole"))
                {
                    square.SetActive(false);
                    triangle.SetActive(true);
                    triangle.transform.position = currPlayerPos;
                    triangle.transform.rotation = currPlayerRot;
                }

            }
            if (playerNum == 1)
            {
                if (Input.GetButtonDown("Select_P2_Asshole"))
                {
                    triangle.SetActive(false);
                    square.SetActive(true);
                    square.transform.position = currPlayerPos;
                    square.transform.rotation = currPlayerRot;
                }
                if (Input.GetButtonUp("Select_P2_Asshole"))
                {
                    square.SetActive(false);
                    triangle.SetActive(true);
                    triangle.transform.position = currPlayerPos;
                    triangle.transform.rotation = currPlayerRot;
                }

            }


        
                }
            }

        