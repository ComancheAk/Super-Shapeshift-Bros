using UnityEngine;
using System.Collections;

public class FontFollows : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = new Vector3(gameObject.GetComponentInParent<PlayerManager>().currPlayerPos.x, gameObject.GetComponentInParent<PlayerManager>().currPlayerPos.y + 4f, 0);
	}
}
