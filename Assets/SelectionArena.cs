using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SelectionArena : MonoBehaviour
{
    public GameObject[] selects;
    //public GameObject[] descriptions;
    public GameObject[] selector;
    public GameObject musMenuControls;
    public int counterP1;
    public int counterP2;
    public float waitTime = 1f;
    public float timerP1;
    //public float timerP2;

    void OnEnable()
    {
        Input.ResetInputAxes();
    }
    // Use this for initialization
    void Awake()
    {
        musMenuControls = GameObject.FindWithTag("Music");
    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.GetAxis("Horizontal_P1"));
        timerP1 += Time.deltaTime;
        //timerP2 += Time.deltaTime;
        if (timerP1 > waitTime)
        {
            if (Input.GetAxis("Vertical") < -0.15f)
            {
                counterP1++;
                //Input.ResetInputAxes();
                timerP1 = 0f;
                if (counterP1 > 5)
                {
                    counterP1 = 0;
                }
                selector[0].transform.parent = selects[counterP1].transform;
                selector[0].transform.position = selects[counterP1].transform.position;
            }
            if (Input.GetAxis("Vertical") > 0.15f)
            {
                counterP1--;
                //Input.ResetInputAxes();
                timerP1 = 0f;
                if (counterP1 < 0)
                {
                    counterP1 = 5;
                }
                selector[0].transform.parent = selects[counterP1].transform;
                selector[0].transform.position = selects[counterP1].transform.position;
            }
            if (Input.GetButton("Start"))
            {
                SceneManager.LoadScene(counterP1+3);
                if (musMenuControls != null)
                {
                    Destroy(musMenuControls);
                }

            }
            if (Input.GetButton("Back"))
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
    
    
