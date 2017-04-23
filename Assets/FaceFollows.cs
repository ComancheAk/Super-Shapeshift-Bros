using UnityEngine;
using System.Collections;

public class FaceFollows : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = new Vector3(gameObject.GetComponentInParent<PlayerManager>().currPlayerPos.x, gameObject.GetComponentInParent<PlayerManager>().currPlayerPos.y, -1);
    }
}
