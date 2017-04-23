using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Selection : MonoBehaviour {
    public GameObject[] selects;
    public GameObject[] descriptions;
    public GameObject selector;
    public GameObject musMenuControls;
    public int counter;
    public float waitTime = 1f;
    public float timer;
    // Use this for initialization

    void Awake()
    {
        musMenuControls = GameObject.FindWithTag("Music");
    }

    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonUp("Start"))
        {
            SceneManager.LoadScene(counter+1);
        }
        if (Input.GetButtonUp("Back"))
        {
            SceneManager.LoadScene(0);
            if (musMenuControls != null)
            {
                Destroy(musMenuControls);
            }
        }

    }
    void FixedUpdate()
    {
        //Input.ResetInputAxes();
    }
}
