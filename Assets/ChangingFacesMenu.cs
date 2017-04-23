using UnityEngine;
using System.Collections;

public class ChangingFacesMenu : MonoBehaviour {
    public Sprite[] face1;
    public float delay = 1f;
    int index;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (delay > 0)
        {
            delay -= Time.deltaTime;
        }
    if (delay < 0)
        {
            index = Random.Range(0, face1.Length);
            if (gameObject.GetComponent<SpriteRenderer>().sprite != face1[index])
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = face1[index];
                delay = 1f;
            } else { index = Random.Range(0, face1.Length); }
        }
	}
}
