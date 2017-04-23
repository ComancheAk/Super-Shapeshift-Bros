using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Selection2P : MonoBehaviour {
    public GameObject[] selects;
    //public GameObject[] descriptions;
    public GameObject[] selector;
    public GameObject musMenuControls;
    public int counterP1;
    public int counterP2;
    public float waitTime = 1f;
    public float timerP1;
    public float timerP2;

    void OnEnable()
    {
        Input.ResetInputAxes();
    }

    void Awake()
    {
        musMenuControls = GameObject.FindWithTag("Music");
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.GetAxis("Horizontal_P1"));
        timerP1 += Time.deltaTime;
        timerP2 += Time.deltaTime;
        if (timerP1 > waitTime)
        {
            if (Input.GetAxis("Horizontal_P1") > -0.15f)
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
            if (Input.GetAxis("Horizontal_P1") < 0.15f)
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
        }

        if (timerP2 > waitTime)
        {
            if (Input.GetAxis("Horizontal_P2") > -0.15f)
            {
                counterP2++;
                //Input.ResetInputAxes();
                timerP2 = 0f;
                if (counterP2 > 5)
                {
                    counterP2 = 0;
                }
                selector[1].transform.parent = selects[counterP2].transform;
                selector[1].transform.position = selects[counterP2].transform.position;
            }
            if (Input.GetAxis("Horizontal_P2") < 0.15f)
            {
                counterP2--;
                //Input.ResetInputAxes();
                timerP2 = 0f;
                if (counterP2 < 0)
                {
                    counterP2 = 5;
                }
                selector[1].transform.parent = selects[counterP2].transform;
                selector[1].transform.position = selects[counterP2].transform.position;
            }
        }
        if (Input.GetButton("Start"))
        {
            switch (counterP1)
            {
                case 5:
                    PlayerPrefs.SetInt("player1_spr", 5);
                    break;
                case 4:
                    PlayerPrefs.SetInt("player1_spr", 4);
                    break;
                case 3:
                    PlayerPrefs.SetInt("player1_spr", 3);
                    break;
                case 2:
                    PlayerPrefs.SetInt("player1_spr", 2);
                    break;
                case 1:
                    PlayerPrefs.SetInt("player1_spr", 1);
                    break;
                default:
                    PlayerPrefs.SetInt("player1_spr", 0);
                    break;
            }

            switch (counterP2)
            {
                case 5:
                    PlayerPrefs.SetInt("player2_spr", 5);
                    break;
                case 4:
                    PlayerPrefs.SetInt("player2_spr", 4);
                    break;
                case 3:
                    PlayerPrefs.SetInt("player2_spr", 3);
                    break;
                case 2:
                    PlayerPrefs.SetInt("player2_spr", 2);
                    break;
                case 1:
                    PlayerPrefs.SetInt("player2_spr", 1);
                    break;
                default:
                    PlayerPrefs.SetInt("player2_spr", 0);
                    break;
            }
            SceneManager.LoadScene(2);
        }
        if (Input.GetButton("Back"))
        {
            SceneManager.LoadScene(0);
            if (musMenuControls != null)
            {
                Destroy(musMenuControls);
            }
        }

    }
}
