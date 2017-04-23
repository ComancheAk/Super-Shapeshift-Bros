using UnityEngine;
using System.Collections;

public class TrisPlatformMovement : MonoBehaviour {
    public Vector3 moveTo;
    public Vector3 OriginPos;
    public Vector3 currPos;
    public float waitTime = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //float step = speed*Time.
        transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, 20.5f), transform.localPosition.z);
        if (transform.localPosition.y == 20.5f)
        {
            waitTime -= Time.deltaTime;
            if (waitTime > 0) {
                transform.localPosition = transform.localPosition;
            }
        }
	}
}
