using UnityEngine;
using System.Collections;

public class PlayerColorChoose : MonoBehaviour {
    public int player;
    public Color col;
    void Awake()
    {
        switch (player)
        {
            case 3:
                col = new Color(PlayerPrefs.GetFloat("player3_r"), PlayerPrefs.GetFloat("player3_b"), PlayerPrefs.GetFloat("player3_g"), 1f);
                break;
            case 2:
                col = new Color(PlayerPrefs.GetFloat("player2_r"), PlayerPrefs.GetFloat("player2_b"), PlayerPrefs.GetFloat("player2_g"), 1f);
                break;
            case 1:
                col = new Color(PlayerPrefs.GetFloat("player2_r"), PlayerPrefs.GetFloat("player2_b"), PlayerPrefs.GetFloat("player2_g"), 1f);
                break;
            default:
                col = new Color(PlayerPrefs.GetFloat("player1_r"), PlayerPrefs.GetFloat("player1_b"), PlayerPrefs.GetFloat("player1_g"), 1f);
                break;
        }
        gameObject.GetComponent<Renderer>().material.color = col;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
