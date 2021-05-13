using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Text ScoreText;

    private void Awake()
    {
        GetInstance();
    }

    private GameManager GetInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else if(Instance == this)
        {
            Destroy(gameObject);
        }

        return Instance;
    }

    public void IncreaseScores()
    {

    }
}
