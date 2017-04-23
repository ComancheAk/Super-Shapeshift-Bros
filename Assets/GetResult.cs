using UnityEngine;
using System.Collections;

public class GetResult : MonoBehaviour {
    public GameObject borders;
    public int playerToShow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (borders != null)
        {
            switch (playerToShow) {
                case 3:
                    gameObject.GetComponent<TextMesh>().text = borders.GetComponent<Borders>().Player4Wins.ToString();
                    break;

                case 2:
                    gameObject.GetComponent<TextMesh>().text = borders.GetComponent<Borders>().Player3Wins.ToString();
                    break;

                case 1:
                    gameObject.GetComponent<TextMesh>().text = borders.GetComponent<Borders>().Player2Wins.ToString();
                    break;

                default:
                    gameObject.GetComponent<TextMesh>().text = borders.GetComponent<Borders>().Player1Wins.ToString();
                    break;

            }
        } 
	}
}
