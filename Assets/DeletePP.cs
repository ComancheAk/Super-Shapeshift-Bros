using UnityEngine;
using System.Collections;

public class DeletePP : MonoBehaviour {

    void Awake()
    {
        PlayerPrefs.DeleteAll();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
