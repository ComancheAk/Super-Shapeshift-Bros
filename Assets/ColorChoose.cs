using UnityEngine;
using System.Collections;

public class ColorChoose : MonoBehaviour {
    public Color clr;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().material.color = clr;
    }
	
	// Update is called once per frame
	void Update () {
        

    }
}
