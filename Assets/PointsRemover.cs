using UnityEngine;
using System.Collections;

public class PointsRemover : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.DeleteKey("player1Wins");
        PlayerPrefs.DeleteKey("player2Wins");

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
