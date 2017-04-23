using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManager;

public class Borders : MonoBehaviour {
    public int playerCounts;
    public int Player1Wins;
    public int Player2Wins;
    public int Player3Wins;
    public int Player4Wins;
    public GameObject game;
    // Use this for initialization
    void Start () {
        Player1Wins = PlayerPrefs.GetInt("player1Wins");
        Player2Wins = PlayerPrefs.GetInt("player2Wins");

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player1")
        {
            Player2Wins++;
            PlayerPrefs.SetInt("player2Wins", Player2Wins);
            game.SetActive(true);
            gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Player2")
        {
            Player1Wins++;
            PlayerPrefs.SetInt("player1Wins", Player1Wins);
            game.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
