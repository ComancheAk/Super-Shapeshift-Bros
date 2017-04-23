using UnityEngine;
using System.Collections;

public class ParentFollows : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        gameObject.GetComponentInParent<PlayerManager>().currPlayerPos = gameObject.transform.position;
        gameObject.GetComponentInParent<PlayerManager>().currPlayerRot = gameObject.transform.rotation;
    }
}
