using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelReloading : MonoBehaviour {
    public float timer = 1.5f;
    public int currScene;
    void Awake()
    {

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
