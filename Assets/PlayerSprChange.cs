using UnityEngine;
using System.Collections;

public class PlayerSprChange : MonoBehaviour {
    public Sprite[] sprs;
    public int player;
    
    // Use this for initialization

    void Awake()
    {
        player = gameObject.GetComponent<RotationTets>().Player;

        switch (player)
        {
            case 3:
                gameObject.GetComponent<SpriteRenderer>().sprite = sprs[PlayerPrefs.GetInt("player4_spr")];
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().sprite = sprs[PlayerPrefs.GetInt("player3_spr")];
                break;
            case 1:
                gameObject.GetComponent<SpriteRenderer>().sprite = sprs[PlayerPrefs.GetInt("player2_spr")];
                break;
            default:
                gameObject.GetComponent<SpriteRenderer>().sprite = sprs[PlayerPrefs.GetInt("player1_spr")];
                break;
        }
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
