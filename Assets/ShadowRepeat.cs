using UnityEngine;
using System.Collections;

public class ShadowRepeat : MonoBehaviour {
    public GameObject follow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(follow.transform.position.x + 0.125f, follow.transform.position.y + 0.125f, 1f);
        transform.rotation = follow.transform.rotation;
	}
}