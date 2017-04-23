using UnityEngine;
using System.Collections;

public class LiftFast : MonoBehaviour {
    public Vector3 moveTo;
    public Vector3 start;
    public Vector3 current;
    public float speed = 100f;
	// Use this for initialization
	void Start () {
        start = transform.position;
        current = moveTo;
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, current, step);
        if (transform.position == moveTo)
        {
            current = start;
        }
        if (transform.position == start)
        {
            current = moveTo;
        }
    }
}
