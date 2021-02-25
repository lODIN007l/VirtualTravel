using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public int ScoreN = 0;
    public string StringScore;
    public Text Text_Score;
    public static GameControler Gamecontroller;

    private void Awake()
    {
        Gamecontroller = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Text_Score != null)
        {
            Text_Score.text = StringScore + ScoreN.ToString();

        }
    }
}

