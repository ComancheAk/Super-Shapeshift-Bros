using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public bool paused;
    public GameObject pausePanel;
    public GameObject musMenuControls;
    //public GameObject cam;
    // public GameObject pauseBtn;
    void Awake()
    {
        musMenuControls = GameObject.FindWithTag("GameMusic");
    }
    // Use this for initialization
    void Start()
    {
        //cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Start"))
        {
            paused = !paused;
        }
        if (pausePanel != null)
        {
            if (paused)
            {
                //pauseBtn.SetActive(false);
                //cam.GetComponent<BlurOptimized>().enabled = true;
                Time.timeScale = 0.0000001f;
                pausePanel.SetActive(true);
                if (Input.GetButtonUp("Back"))
                {
                    Time.timeScale = 1f;
                    SceneManager.LoadScene(2);
                    if (musMenuControls != null)
                    {
                        Destroy(musMenuControls);
                    }
                }

            }
            else {
                //pauseBtn.SetActive(true);
                //cam.GetComponent<BlurOptimized>().enabled = false;
                Time.timeScale = 1f;
                pausePanel.SetActive(false);
            }
        }
        

    }
}
